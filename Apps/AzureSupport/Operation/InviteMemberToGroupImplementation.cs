﻿using System;
using System.IO;
using System.Linq;
using TheBall;
using TheBall.CORE;

namespace AaltoGlobalImpact.OIP
{
    public static class InviteMemberToGroupImplementation
    {
        public static TBRGroupRoot GetTarget_GroupRoot(string groupID)
        {
            return ObjectStorage.RetrieveFromDefaultLocation<TBRGroupRoot>(groupID);
        }

        public static TBEmailValidation GetTarget_EmailValidation(string memberEmailAddress, string groupID)
        {
            TBEmailValidation emailValidation = new TBEmailValidation();
            emailValidation.Email = memberEmailAddress;
            emailValidation.ValidUntil = DateTime.UtcNow.AddDays(14); // Two weeks to accept the group join
            emailValidation.GroupJoinConfirmation = new TBGroupJoinConfirmation
            {
                GroupID = groupID
            };
            return emailValidation;
        }

        public static GroupContainer GetTarget_GroupInternalContainer(string groupID)
        {
            VirtualOwner owner = new VirtualOwner("grp", groupID);
            var groupContainer = ObjectStorage.RetrieveFromOwnerContent<GroupContainer>(owner, "default");
            return groupContainer;
        }

        public static void ExecuteMethod_AddAsPendingInvitationToGroupRoot(string memberEmailAddress, string memberRole, TBRGroupRoot groupRoot)
        {
            if (string.IsNullOrEmpty(memberRole))
                memberRole = TBCollaboratorRole.CollaboratorRoleValue;
            TBCollaboratorRole role =
                groupRoot.Group.Roles.CollectionContent.FirstOrDefault(
                    candidate => candidate.Email.EmailAddress == memberEmailAddress);
            if (role != null)
            {
                if (role.IsRoleStatusValidMember())
                    throw new InvalidDataException("Person to be invited is already member of the group");
            }
            else
            {
                role = TBCollaboratorRole.CreateDefault();
                role.Email.EmailAddress = memberEmailAddress;
                role.Role = memberRole;
                role.SetRoleAsInvited();
                groupRoot.Group.Roles.CollectionContent.Add(role);
            }
        }

        public static void ExecuteMethod_StoreObjects(TBRGroupRoot groupRoot, TBEmailValidation emailValidation)
        {
            groupRoot.StoreInformation();
            emailValidation.StoreInformation();
        }

        public static void ExecuteMethod_SendEmailConfirmation(bool dontSendEmailInvitation, TBEmailValidation emailValidation, TBRGroupRoot groupRoot)
        {
            if(dontSendEmailInvitation == false)
                EmailSupport.SendGroupJoinEmail(emailValidation, groupRoot.Group);
        }

        public static string GetTarget_AccountID(string memberEmailAddress)
        {
            string emailRootID = TBREmailRoot.GetIDFromEmailAddress(memberEmailAddress);
            TBREmailRoot emailRoot = ObjectStorage.RetrieveFromDefaultLocation<TBREmailRoot>(emailRootID);
            return emailRoot.Account.ID;
        }

        public static RefreshAccountGroupMembershipsParameters RefreshAccountAndGroupContainers_GetParameters(TBRGroupRoot groupRoot, string accountID)
        {
            return new RefreshAccountGroupMembershipsParameters() {AccountID = accountID, GroupRoot = groupRoot};
        }
    }
}