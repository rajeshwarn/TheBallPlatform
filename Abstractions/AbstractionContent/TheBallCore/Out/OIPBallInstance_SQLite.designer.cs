 


using System;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Xml;
using System.Linq;
using System.Runtime.Serialization;

namespace SQLite.AaltoGlobalImpact.OIP { 
		
		public class TheBallDataContext : DataContext
		{

            public TheBallDataContext(IDbConnection connection) : base(connection)
		    {

		    }

			public Table<TBSystem> TBSystemTable {
				get {
					return this.GetTable<TBSystem>();
				}
			}
			public Table<WebPublishInfo> WebPublishInfoTable {
				get {
					return this.GetTable<WebPublishInfo>();
				}
			}
			public Table<PublicationPackage> PublicationPackageTable {
				get {
					return this.GetTable<PublicationPackage>();
				}
			}
			public Table<TBRLoginRoot> TBRLoginRootTable {
				get {
					return this.GetTable<TBRLoginRoot>();
				}
			}
			public Table<TBRAccountRoot> TBRAccountRootTable {
				get {
					return this.GetTable<TBRAccountRoot>();
				}
			}
			public Table<TBRGroupRoot> TBRGroupRootTable {
				get {
					return this.GetTable<TBRGroupRoot>();
				}
			}
			public Table<TBRLoginGroupRoot> TBRLoginGroupRootTable {
				get {
					return this.GetTable<TBRLoginGroupRoot>();
				}
			}
			public Table<TBREmailRoot> TBREmailRootTable {
				get {
					return this.GetTable<TBREmailRoot>();
				}
			}
			public Table<TBAccount> TBAccountTable {
				get {
					return this.GetTable<TBAccount>();
				}
			}
			public Table<TBAccountCollaborationGroup> TBAccountCollaborationGroupTable {
				get {
					return this.GetTable<TBAccountCollaborationGroup>();
				}
			}
			public Table<TBLoginInfo> TBLoginInfoTable {
				get {
					return this.GetTable<TBLoginInfo>();
				}
			}
			public Table<TBEmail> TBEmailTable {
				get {
					return this.GetTable<TBEmail>();
				}
			}
			public Table<TBCollaboratorRole> TBCollaboratorRoleTable {
				get {
					return this.GetTable<TBCollaboratorRole>();
				}
			}
			public Table<TBCollaboratingGroup> TBCollaboratingGroupTable {
				get {
					return this.GetTable<TBCollaboratingGroup>();
				}
			}
			public Table<TBEmailValidation> TBEmailValidationTable {
				get {
					return this.GetTable<TBEmailValidation>();
				}
			}
			public Table<TBMergeAccountConfirmation> TBMergeAccountConfirmationTable {
				get {
					return this.GetTable<TBMergeAccountConfirmation>();
				}
			}
			public Table<TBGroupJoinConfirmation> TBGroupJoinConfirmationTable {
				get {
					return this.GetTable<TBGroupJoinConfirmation>();
				}
			}
			public Table<TBDeviceJoinConfirmation> TBDeviceJoinConfirmationTable {
				get {
					return this.GetTable<TBDeviceJoinConfirmation>();
				}
			}
			public Table<TBInformationInputConfirmation> TBInformationInputConfirmationTable {
				get {
					return this.GetTable<TBInformationInputConfirmation>();
				}
			}
			public Table<TBInformationOutputConfirmation> TBInformationOutputConfirmationTable {
				get {
					return this.GetTable<TBInformationOutputConfirmation>();
				}
			}
			public Table<TBRegisterContainer> TBRegisterContainerTable {
				get {
					return this.GetTable<TBRegisterContainer>();
				}
			}
			public Table<LoginProvider> LoginProviderTable {
				get {
					return this.GetTable<LoginProvider>();
				}
			}
			public Table<ContactOipContainer> ContactOipContainerTable {
				get {
					return this.GetTable<ContactOipContainer>();
				}
			}
			public Table<TBPRegisterEmail> TBPRegisterEmailTable {
				get {
					return this.GetTable<TBPRegisterEmail>();
				}
			}
			public Table<JavaScriptContainer> JavaScriptContainerTable {
				get {
					return this.GetTable<JavaScriptContainer>();
				}
			}
			public Table<JavascriptContainer> JavascriptContainerTable {
				get {
					return this.GetTable<JavascriptContainer>();
				}
			}
			public Table<FooterContainer> FooterContainerTable {
				get {
					return this.GetTable<FooterContainer>();
				}
			}
			public Table<NavigationContainer> NavigationContainerTable {
				get {
					return this.GetTable<NavigationContainer>();
				}
			}
			public Table<AccountSummary> AccountSummaryTable {
				get {
					return this.GetTable<AccountSummary>();
				}
			}
			public Table<AccountContainer> AccountContainerTable {
				get {
					return this.GetTable<AccountContainer>();
				}
			}
			public Table<AccountIndex> AccountIndexTable {
				get {
					return this.GetTable<AccountIndex>();
				}
			}
			public Table<AccountModule> AccountModuleTable {
				get {
					return this.GetTable<AccountModule>();
				}
			}
			public Table<ImageGroupContainer> ImageGroupContainerTable {
				get {
					return this.GetTable<ImageGroupContainer>();
				}
			}
			public Table<LocationContainer> LocationContainerTable {
				get {
					return this.GetTable<LocationContainer>();
				}
			}
			public Table<AddressAndLocation> AddressAndLocationTable {
				get {
					return this.GetTable<AddressAndLocation>();
				}
			}
			public Table<StreetAddress> StreetAddressTable {
				get {
					return this.GetTable<StreetAddress>();
				}
			}
			public Table<AccountContent> AccountContentTable {
				get {
					return this.GetTable<AccountContent>();
				}
			}
			public Table<AccountProfile> AccountProfileTable {
				get {
					return this.GetTable<AccountProfile>();
				}
			}
			public Table<AccountSecurity> AccountSecurityTable {
				get {
					return this.GetTable<AccountSecurity>();
				}
			}
			public Table<AccountRoles> AccountRolesTable {
				get {
					return this.GetTable<AccountRoles>();
				}
			}
			public Table<PersonalInfoVisibility> PersonalInfoVisibilityTable {
				get {
					return this.GetTable<PersonalInfoVisibility>();
				}
			}
			public Table<GroupedInformation> GroupedInformationTable {
				get {
					return this.GetTable<GroupedInformation>();
				}
			}
			public Table<ReferenceToInformation> ReferenceToInformationTable {
				get {
					return this.GetTable<ReferenceToInformation>();
				}
			}
			public Table<BlogContainer> BlogContainerTable {
				get {
					return this.GetTable<BlogContainer>();
				}
			}
			public Table<RecentBlogSummary> RecentBlogSummaryTable {
				get {
					return this.GetTable<RecentBlogSummary>();
				}
			}
			public Table<NodeSummaryContainer> NodeSummaryContainerTable {
				get {
					return this.GetTable<NodeSummaryContainer>();
				}
			}
			public Table<RenderedNode> RenderedNodeTable {
				get {
					return this.GetTable<RenderedNode>();
				}
			}
			public Table<ShortTextObject> ShortTextObjectTable {
				get {
					return this.GetTable<ShortTextObject>();
				}
			}
			public Table<LongTextObject> LongTextObjectTable {
				get {
					return this.GetTable<LongTextObject>();
				}
			}
			public Table<MapContainer> MapContainerTable {
				get {
					return this.GetTable<MapContainer>();
				}
			}
			public Table<MapMarker> MapMarkerTable {
				get {
					return this.GetTable<MapMarker>();
				}
			}
			public Table<CalendarContainer> CalendarContainerTable {
				get {
					return this.GetTable<CalendarContainer>();
				}
			}
			public Table<AboutContainer> AboutContainerTable {
				get {
					return this.GetTable<AboutContainer>();
				}
			}
			public Table<OBSAccountContainer> OBSAccountContainerTable {
				get {
					return this.GetTable<OBSAccountContainer>();
				}
			}
			public Table<ProjectContainer> ProjectContainerTable {
				get {
					return this.GetTable<ProjectContainer>();
				}
			}
			public Table<CourseContainer> CourseContainerTable {
				get {
					return this.GetTable<CourseContainer>();
				}
			}
			public Table<ContainerHeader> ContainerHeaderTable {
				get {
					return this.GetTable<ContainerHeader>();
				}
			}
			public Table<ActivitySummaryContainer> ActivitySummaryContainerTable {
				get {
					return this.GetTable<ActivitySummaryContainer>();
				}
			}
			public Table<ActivityIndex> ActivityIndexTable {
				get {
					return this.GetTable<ActivityIndex>();
				}
			}
			public Table<ActivityContainer> ActivityContainerTable {
				get {
					return this.GetTable<ActivityContainer>();
				}
			}
			public Table<Activity> ActivityTable {
				get {
					return this.GetTable<Activity>();
				}
			}
			public Table<Moderator> ModeratorTable {
				get {
					return this.GetTable<Moderator>();
				}
			}
			public Table<Collaborator> CollaboratorTable {
				get {
					return this.GetTable<Collaborator>();
				}
			}
			public Table<GroupSummaryContainer> GroupSummaryContainerTable {
				get {
					return this.GetTable<GroupSummaryContainer>();
				}
			}
			public Table<GroupContainer> GroupContainerTable {
				get {
					return this.GetTable<GroupContainer>();
				}
			}
			public Table<GroupIndex> GroupIndexTable {
				get {
					return this.GetTable<GroupIndex>();
				}
			}
			public Table<AddAddressAndLocationInfo> AddAddressAndLocationInfoTable {
				get {
					return this.GetTable<AddAddressAndLocationInfo>();
				}
			}
			public Table<AddImageInfo> AddImageInfoTable {
				get {
					return this.GetTable<AddImageInfo>();
				}
			}
			public Table<AddImageGroupInfo> AddImageGroupInfoTable {
				get {
					return this.GetTable<AddImageGroupInfo>();
				}
			}
			public Table<AddEmailAddressInfo> AddEmailAddressInfoTable {
				get {
					return this.GetTable<AddEmailAddressInfo>();
				}
			}
			public Table<CreateGroupInfo> CreateGroupInfoTable {
				get {
					return this.GetTable<CreateGroupInfo>();
				}
			}
			public Table<AddActivityInfo> AddActivityInfoTable {
				get {
					return this.GetTable<AddActivityInfo>();
				}
			}
			public Table<AddBlogPostInfo> AddBlogPostInfoTable {
				get {
					return this.GetTable<AddBlogPostInfo>();
				}
			}
			public Table<AddCategoryInfo> AddCategoryInfoTable {
				get {
					return this.GetTable<AddCategoryInfo>();
				}
			}
			public Table<Group> GroupTable {
				get {
					return this.GetTable<Group>();
				}
			}
			public Table<Introduction> IntroductionTable {
				get {
					return this.GetTable<Introduction>();
				}
			}
			public Table<ContentCategoryRank> ContentCategoryRankTable {
				get {
					return this.GetTable<ContentCategoryRank>();
				}
			}
			public Table<LinkToContent> LinkToContentTable {
				get {
					return this.GetTable<LinkToContent>();
				}
			}
			public Table<EmbeddedContent> EmbeddedContentTable {
				get {
					return this.GetTable<EmbeddedContent>();
				}
			}
			public Table<DynamicContentGroup> DynamicContentGroupTable {
				get {
					return this.GetTable<DynamicContentGroup>();
				}
			}
			public Table<DynamicContent> DynamicContentTable {
				get {
					return this.GetTable<DynamicContent>();
				}
			}
			public Table<AttachedToObject> AttachedToObjectTable {
				get {
					return this.GetTable<AttachedToObject>();
				}
			}
			public Table<Comment> CommentTable {
				get {
					return this.GetTable<Comment>();
				}
			}
			public Table<Selection> SelectionTable {
				get {
					return this.GetTable<Selection>();
				}
			}
			public Table<TextContent> TextContentTable {
				get {
					return this.GetTable<TextContent>();
				}
			}
			public Table<Blog> BlogTable {
				get {
					return this.GetTable<Blog>();
				}
			}
			public Table<BlogIndexGroup> BlogIndexGroupTable {
				get {
					return this.GetTable<BlogIndexGroup>();
				}
			}
			public Table<CalendarIndex> CalendarIndexTable {
				get {
					return this.GetTable<CalendarIndex>();
				}
			}
			public Table<Filter> FilterTable {
				get {
					return this.GetTable<Filter>();
				}
			}
			public Table<Calendar> CalendarTable {
				get {
					return this.GetTable<Calendar>();
				}
			}
			public Table<Map> MapTable {
				get {
					return this.GetTable<Map>();
				}
			}
			public Table<MapIndexCollection> MapIndexCollectionTable {
				get {
					return this.GetTable<MapIndexCollection>();
				}
			}
			public Table<MapResult> MapResultTable {
				get {
					return this.GetTable<MapResult>();
				}
			}
			public Table<MapResultsCollection> MapResultsCollectionTable {
				get {
					return this.GetTable<MapResultsCollection>();
				}
			}
			public Table<Video> VideoTable {
				get {
					return this.GetTable<Video>();
				}
			}
			public Table<Image> ImageTable {
				get {
					return this.GetTable<Image>();
				}
			}
			public Table<BinaryFile> BinaryFileTable {
				get {
					return this.GetTable<BinaryFile>();
				}
			}
			public Table<ImageGroup> ImageGroupTable {
				get {
					return this.GetTable<ImageGroup>();
				}
			}
			public Table<VideoGroup> VideoGroupTable {
				get {
					return this.GetTable<VideoGroup>();
				}
			}
			public Table<Tooltip> TooltipTable {
				get {
					return this.GetTable<Tooltip>();
				}
			}
			public Table<SocialPanel> SocialPanelTable {
				get {
					return this.GetTable<SocialPanel>();
				}
			}
			public Table<Longitude> LongitudeTable {
				get {
					return this.GetTable<Longitude>();
				}
			}
			public Table<Latitude> LatitudeTable {
				get {
					return this.GetTable<Latitude>();
				}
			}
			public Table<Location> LocationTable {
				get {
					return this.GetTable<Location>();
				}
			}
			public Table<Date> DateTable {
				get {
					return this.GetTable<Date>();
				}
			}
			public Table<Sex> SexTable {
				get {
					return this.GetTable<Sex>();
				}
			}
			public Table<OBSAddress> OBSAddressTable {
				get {
					return this.GetTable<OBSAddress>();
				}
			}
			public Table<Identity> IdentityTable {
				get {
					return this.GetTable<Identity>();
				}
			}
			public Table<ImageVideoSoundVectorRaw> ImageVideoSoundVectorRawTable {
				get {
					return this.GetTable<ImageVideoSoundVectorRaw>();
				}
			}
			public Table<CategoryContainer> CategoryContainerTable {
				get {
					return this.GetTable<CategoryContainer>();
				}
			}
			public Table<Category> CategoryTable {
				get {
					return this.GetTable<Category>();
				}
			}
			public Table<Subscription> SubscriptionTable {
				get {
					return this.GetTable<Subscription>();
				}
			}
			public Table<QueueEnvelope> QueueEnvelopeTable {
				get {
					return this.GetTable<QueueEnvelope>();
				}
			}
			public Table<OperationRequest> OperationRequestTable {
				get {
					return this.GetTable<OperationRequest>();
				}
			}
			public Table<SubscriptionChainRequestMessage> SubscriptionChainRequestMessageTable {
				get {
					return this.GetTable<SubscriptionChainRequestMessage>();
				}
			}
			public Table<SubscriptionChainRequestContent> SubscriptionChainRequestContentTable {
				get {
					return this.GetTable<SubscriptionChainRequestContent>();
				}
			}
			public Table<SubscriptionTarget> SubscriptionTargetTable {
				get {
					return this.GetTable<SubscriptionTarget>();
				}
			}
			public Table<DeleteEntireOwnerOperation> DeleteEntireOwnerOperationTable {
				get {
					return this.GetTable<DeleteEntireOwnerOperation>();
				}
			}
			public Table<DeleteOwnerContentOperation> DeleteOwnerContentOperationTable {
				get {
					return this.GetTable<DeleteOwnerContentOperation>();
				}
			}
			public Table<SystemError> SystemErrorTable {
				get {
					return this.GetTable<SystemError>();
				}
			}
			public Table<SystemErrorItem> SystemErrorItemTable {
				get {
					return this.GetTable<SystemErrorItem>();
				}
			}
			public Table<InformationSource> InformationSourceTable {
				get {
					return this.GetTable<InformationSource>();
				}
			}
			public Table<RefreshDefaultViewsOperation> RefreshDefaultViewsOperationTable {
				get {
					return this.GetTable<RefreshDefaultViewsOperation>();
				}
			}
			public Table<UpdateWebContentOperation> UpdateWebContentOperationTable {
				get {
					return this.GetTable<UpdateWebContentOperation>();
				}
			}
			public Table<UpdateWebContentHandlerItem> UpdateWebContentHandlerItemTable {
				get {
					return this.GetTable<UpdateWebContentHandlerItem>();
				}
			}
			public Table<PublishWebContentOperation> PublishWebContentOperationTable {
				get {
					return this.GetTable<PublishWebContentOperation>();
				}
			}
			public Table<SubscriberInput> SubscriberInputTable {
				get {
					return this.GetTable<SubscriberInput>();
				}
			}
			public Table<Monitor> MonitorTable {
				get {
					return this.GetTable<Monitor>();
				}
			}
			public Table<IconTitleDescription> IconTitleDescriptionTable {
				get {
					return this.GetTable<IconTitleDescription>();
				}
			}
			public Table<AboutAGIApplications> AboutAGIApplicationsTable {
				get {
					return this.GetTable<AboutAGIApplications>();
				}
			}
        }

    [Table(Name = "TBSystem")]
	public class TBSystem
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string InstanceName { get; set; }
		// private string _unmodified_InstanceName;

		[Column]
		public string AdminGroupID { get; set; }
		// private string _unmodified_AdminGroupID;
	}
    [Table(Name = "WebPublishInfo")]
	public class WebPublishInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string PublishType { get; set; }
		// private string _unmodified_PublishType;

		[Column]
		public string PublishContainer { get; set; }
		// private string _unmodified_PublishContainer;

		[Column]
		public PublicationPackage ActivePublication { get; set; }
		// private PublicationPackage _unmodified_ActivePublication;

		[Column]
		public PublicationPackageCollection Publications { get; set; }
		// private PublicationPackageCollection _unmodified_Publications;
	}
    [Table(Name = "PublicationPackage")]
	public class PublicationPackage
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string PackageName { get; set; }
		// private string _unmodified_PackageName;

		[Column]
		public DateTime PublicationTime { get; set; }
		// private DateTime _unmodified_PublicationTime;
	}
    [Table(Name = "TBRLoginRoot")]
	public class TBRLoginRoot
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string DomainName { get; set; }
		// private string _unmodified_DomainName;

		[Column]
		public TBAccount Account { get; set; }
		// private TBAccount _unmodified_Account;
	}
    [Table(Name = "TBRAccountRoot")]
	public class TBRAccountRoot
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public TBAccount Account { get; set; }
		// private TBAccount _unmodified_Account;
	}
    [Table(Name = "TBRGroupRoot")]
	public class TBRGroupRoot
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public TBCollaboratingGroup Group { get; set; }
		// private TBCollaboratingGroup _unmodified_Group;
	}
    [Table(Name = "TBRLoginGroupRoot")]
	public class TBRLoginGroupRoot
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Role { get; set; }
		// private string _unmodified_Role;

		[Column]
		public string GroupID { get; set; }
		// private string _unmodified_GroupID;
	}
    [Table(Name = "TBREmailRoot")]
	public class TBREmailRoot
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public TBAccount Account { get; set; }
		// private TBAccount _unmodified_Account;
	}
    [Table(Name = "TBAccount")]
	public class TBAccount
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public TBEmailCollection Emails { get; set; }
		// private TBEmailCollection _unmodified_Emails;

		[Column]
		public TBLoginInfoCollection Logins { get; set; }
		// private TBLoginInfoCollection _unmodified_Logins;

		[Column]
		public TBAccountCollaborationGroupCollection GroupRoleCollection { get; set; }
		// private TBAccountCollaborationGroupCollection _unmodified_GroupRoleCollection;
	}
    [Table(Name = "TBAccountCollaborationGroup")]
	public class TBAccountCollaborationGroup
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupID { get; set; }
		// private string _unmodified_GroupID;

		[Column]
		public string GroupRole { get; set; }
		// private string _unmodified_GroupRole;

		[Column]
		public string RoleStatus { get; set; }
		// private string _unmodified_RoleStatus;
	}
    [Table(Name = "TBLoginInfo")]
	public class TBLoginInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string OpenIDUrl { get; set; }
		// private string _unmodified_OpenIDUrl;
	}
    [Table(Name = "TBEmail")]
	public class TBEmail
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string EmailAddress { get; set; }
		// private string _unmodified_EmailAddress;

		[Column]
		public DateTime ValidatedAt { get; set; }
		// private DateTime _unmodified_ValidatedAt;
	}
    [Table(Name = "TBCollaboratorRole")]
	public class TBCollaboratorRole
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public TBEmail Email { get; set; }
		// private TBEmail _unmodified_Email;

		[Column]
		public string Role { get; set; }
		// private string _unmodified_Role;

		[Column]
		public string RoleStatus { get; set; }
		// private string _unmodified_RoleStatus;
	}
    [Table(Name = "TBCollaboratingGroup")]
	public class TBCollaboratingGroup
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public TBCollaboratorRoleCollection Roles { get; set; }
		// private TBCollaboratorRoleCollection _unmodified_Roles;
	}
    [Table(Name = "TBEmailValidation")]
	public class TBEmailValidation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Email { get; set; }
		// private string _unmodified_Email;

		[Column]
		public string AccountID { get; set; }
		// private string _unmodified_AccountID;

		[Column]
		public DateTime ValidUntil { get; set; }
		// private DateTime _unmodified_ValidUntil;

		[Column]
		public TBGroupJoinConfirmation GroupJoinConfirmation { get; set; }
		// private TBGroupJoinConfirmation _unmodified_GroupJoinConfirmation;

		[Column]
		public TBDeviceJoinConfirmation DeviceJoinConfirmation { get; set; }
		// private TBDeviceJoinConfirmation _unmodified_DeviceJoinConfirmation;

		[Column]
		public TBInformationInputConfirmation InformationInputConfirmation { get; set; }
		// private TBInformationInputConfirmation _unmodified_InformationInputConfirmation;

		[Column]
		public TBInformationOutputConfirmation InformationOutputConfirmation { get; set; }
		// private TBInformationOutputConfirmation _unmodified_InformationOutputConfirmation;

		[Column]
		public TBMergeAccountConfirmation MergeAccountsConfirmation { get; set; }
		// private TBMergeAccountConfirmation _unmodified_MergeAccountsConfirmation;

		[Column]
		public string RedirectUrlAfterValidation { get; set; }
		// private string _unmodified_RedirectUrlAfterValidation;
	}
    [Table(Name = "TBMergeAccountConfirmation")]
	public class TBMergeAccountConfirmation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string AccountToBeMergedID { get; set; }
		// private string _unmodified_AccountToBeMergedID;

		[Column]
		public string AccountToMergeToID { get; set; }
		// private string _unmodified_AccountToMergeToID;
	}
    [Table(Name = "TBGroupJoinConfirmation")]
	public class TBGroupJoinConfirmation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupID { get; set; }
		// private string _unmodified_GroupID;

		[Column]
		public string InvitationMode { get; set; }
		// private string _unmodified_InvitationMode;
	}
    [Table(Name = "TBDeviceJoinConfirmation")]
	public class TBDeviceJoinConfirmation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupID { get; set; }
		// private string _unmodified_GroupID;

		[Column]
		public string AccountID { get; set; }
		// private string _unmodified_AccountID;

		[Column]
		public string DeviceMembershipID { get; set; }
		// private string _unmodified_DeviceMembershipID;
	}
    [Table(Name = "TBInformationInputConfirmation")]
	public class TBInformationInputConfirmation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupID { get; set; }
		// private string _unmodified_GroupID;

		[Column]
		public string AccountID { get; set; }
		// private string _unmodified_AccountID;

		[Column]
		public string InformationInputID { get; set; }
		// private string _unmodified_InformationInputID;
	}
    [Table(Name = "TBInformationOutputConfirmation")]
	public class TBInformationOutputConfirmation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupID { get; set; }
		// private string _unmodified_GroupID;

		[Column]
		public string AccountID { get; set; }
		// private string _unmodified_AccountID;

		[Column]
		public string InformationOutputID { get; set; }
		// private string _unmodified_InformationOutputID;
	}
    [Table(Name = "TBRegisterContainer")]
	public class TBRegisterContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public string ReturnUrl { get; set; }
		// private string _unmodified_ReturnUrl;

		[Column]
		public LoginProviderCollection LoginProviderCollection { get; set; }
		// private LoginProviderCollection _unmodified_LoginProviderCollection;
	}
    [Table(Name = "LoginProvider")]
	public class LoginProvider
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ProviderName { get; set; }
		// private string _unmodified_ProviderName;

		[Column]
		public string ProviderIconClass { get; set; }
		// private string _unmodified_ProviderIconClass;

		[Column]
		public string ProviderType { get; set; }
		// private string _unmodified_ProviderType;

		[Column]
		public string ProviderUrl { get; set; }
		// private string _unmodified_ProviderUrl;

		[Column]
		public string ReturnUrl { get; set; }
		// private string _unmodified_ReturnUrl;
	}
    [Table(Name = "ContactOipContainer")]
	public class ContactOipContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string OIPModeratorGroupID { get; set; }
		// private string _unmodified_OIPModeratorGroupID;
	}
    [Table(Name = "TBPRegisterEmail")]
	public class TBPRegisterEmail
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string EmailAddress { get; set; }
		// private string _unmodified_EmailAddress;
	}
    [Table(Name = "JavaScriptContainer")]
	public class JavaScriptContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string HtmlContent { get; set; }
		// private string _unmodified_HtmlContent;
	}
    [Table(Name = "JavascriptContainer")]
	public class JavascriptContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string HtmlContent { get; set; }
		// private string _unmodified_HtmlContent;
	}
    [Table(Name = "FooterContainer")]
	public class FooterContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string HtmlContent { get; set; }
		// private string _unmodified_HtmlContent;
	}
    [Table(Name = "NavigationContainer")]
	public class NavigationContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Dummy { get; set; }
		// private string _unmodified_Dummy;
	}
    [Table(Name = "AccountSummary")]
	public class AccountSummary
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Introduction Introduction { get; set; }
		// private Introduction _unmodified_Introduction;

		[Column]
		public ActivitySummaryContainer ActivitySummary { get; set; }
		// private ActivitySummaryContainer _unmodified_ActivitySummary;

		[Column]
		public GroupSummaryContainer GroupSummary { get; set; }
		// private GroupSummaryContainer _unmodified_GroupSummary;
	}
    [Table(Name = "AccountContainer")]
	public class AccountContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public AccountIndex AccountIndex { get; set; }
		// private AccountIndex _unmodified_AccountIndex;

		[Column]
		public AccountModule AccountModule { get; set; }
		// private AccountModule _unmodified_AccountModule;

		[Column]
		public AccountSummary AccountSummary { get; set; }
		// private AccountSummary _unmodified_AccountSummary;
	}
    [Table(Name = "AccountIndex")]
	public class AccountIndex
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image Icon { get; set; }
		// private Image _unmodified_Icon;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Introduction { get; set; }
		// private string _unmodified_Introduction;

		[Column]
		public string Summary { get; set; }
		// private string _unmodified_Summary;
	}
    [Table(Name = "AccountModule")]
	public class AccountModule
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public AccountProfile Profile { get; set; }
		// private AccountProfile _unmodified_Profile;

		[Column]
		public AccountSecurity Security { get; set; }
		// private AccountSecurity _unmodified_Security;

		[Column]
		public AccountRoles Roles { get; set; }
		// private AccountRoles _unmodified_Roles;

		[Column]
		public AddressAndLocationCollection LocationCollection { get; set; }
		// private AddressAndLocationCollection _unmodified_LocationCollection;
	}
    [Table(Name = "ImageGroupContainer")]
	public class ImageGroupContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ImageGroupCollection ImageGroups { get; set; }
		// private ImageGroupCollection _unmodified_ImageGroups;
	}
    [Table(Name = "LocationContainer")]
	public class LocationContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public AddressAndLocationCollection Locations { get; set; }
		// private AddressAndLocationCollection _unmodified_Locations;
	}
    [Table(Name = "AddressAndLocation")]
	public class AddressAndLocation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public StreetAddress Address { get; set; }
		// private StreetAddress _unmodified_Address;

		[Column]
		public Location Location { get; set; }
		// private Location _unmodified_Location;
	}
    [Table(Name = "StreetAddress")]
	public class StreetAddress
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Street { get; set; }
		// private string _unmodified_Street;

		[Column]
		public string ZipCode { get; set; }
		// private string _unmodified_ZipCode;

		[Column]
		public string Town { get; set; }
		// private string _unmodified_Town;

		[Column]
		public string Country { get; set; }
		// private string _unmodified_Country;
	}
    [Table(Name = "AccountContent")]
	public class AccountContent
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Dummy { get; set; }
		// private string _unmodified_Dummy;
	}
    [Table(Name = "AccountProfile")]
	public class AccountProfile
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image ProfileImage { get; set; }
		// private Image _unmodified_ProfileImage;

		[Column]
		public string FirstName { get; set; }
		// private string _unmodified_FirstName;

		[Column]
		public string LastName { get; set; }
		// private string _unmodified_LastName;

		[Column]
		public StreetAddress Address { get; set; }
		// private StreetAddress _unmodified_Address;

		[Column]
		public bool IsSimplifiedAccount { get; set; }
		// private bool _unmodified_IsSimplifiedAccount;

		[Column]
		public string SimplifiedAccountEmail { get; set; }
		// private string _unmodified_SimplifiedAccountEmail;

		[Column]
		public string SimplifiedAccountGroupID { get; set; }
		// private string _unmodified_SimplifiedAccountGroupID;
	}
    [Table(Name = "AccountSecurity")]
	public class AccountSecurity
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public TBLoginInfoCollection LoginInfoCollection { get; set; }
		// private TBLoginInfoCollection _unmodified_LoginInfoCollection;

		[Column]
		public TBEmailCollection EmailCollection { get; set; }
		// private TBEmailCollection _unmodified_EmailCollection;
	}
    [Table(Name = "AccountRoles")]
	public class AccountRoles
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceCollection ModeratorInGroups { get; set; }
		// private ReferenceCollection _unmodified_ModeratorInGroups;

		[Column]
		public ReferenceCollection MemberInGroups { get; set; }
		// private ReferenceCollection _unmodified_MemberInGroups;

		[Column]
		public string OrganizationsImPartOf { get; set; }
		// private string _unmodified_OrganizationsImPartOf;
	}
    [Table(Name = "PersonalInfoVisibility")]
	public class PersonalInfoVisibility
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string NoOne_Network_All { get; set; }
		// private string _unmodified_NoOne_Network_All;
	}
    [Table(Name = "GroupedInformation")]
	public class GroupedInformation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupName { get; set; }
		// private string _unmodified_GroupName;

		[Column]
		public ReferenceCollection ReferenceCollection { get; set; }
		// private ReferenceCollection _unmodified_ReferenceCollection;
	}
    [Table(Name = "ReferenceToInformation")]
	public class ReferenceToInformation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string URL { get; set; }
		// private string _unmodified_URL;
	}
    [Table(Name = "BlogContainer")]
	public class BlogContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public Blog FeaturedBlog { get; set; }
		// private Blog _unmodified_FeaturedBlog;

		[Column]
		public RecentBlogSummary RecentBlogSummary { get; set; }
		// private RecentBlogSummary _unmodified_RecentBlogSummary;

		[Column]
		public BlogIndexGroup BlogIndexGroup { get; set; }
		// private BlogIndexGroup _unmodified_BlogIndexGroup;
	}
    [Table(Name = "RecentBlogSummary")]
	public class RecentBlogSummary
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Introduction Introduction { get; set; }
		// private Introduction _unmodified_Introduction;

		[Column]
		public BlogCollection RecentBlogCollection { get; set; }
		// private BlogCollection _unmodified_RecentBlogCollection;
	}
    [Table(Name = "NodeSummaryContainer")]
	public class NodeSummaryContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public RenderedNodeCollection Nodes { get; set; }
		// private RenderedNodeCollection _unmodified_Nodes;

		[Column]
		public BlogCollection NodeSourceBlogs { get; set; }
		// private BlogCollection _unmodified_NodeSourceBlogs;

		[Column]
		public ActivityCollection NodeSourceActivities { get; set; }
		// private ActivityCollection _unmodified_NodeSourceActivities;

		[Column]
		public TextContentCollection NodeSourceTextContent { get; set; }
		// private TextContentCollection _unmodified_NodeSourceTextContent;

		[Column]
		public LinkToContentCollection NodeSourceLinkToContent { get; set; }
		// private LinkToContentCollection _unmodified_NodeSourceLinkToContent;

		[Column]
		public EmbeddedContentCollection NodeSourceEmbeddedContent { get; set; }
		// private EmbeddedContentCollection _unmodified_NodeSourceEmbeddedContent;

		[Column]
		public ImageCollection NodeSourceImages { get; set; }
		// private ImageCollection _unmodified_NodeSourceImages;

		[Column]
		public BinaryFileCollection NodeSourceBinaryFiles { get; set; }
		// private BinaryFileCollection _unmodified_NodeSourceBinaryFiles;

		[Column]
		public CategoryCollection NodeSourceCategories { get; set; }
		// private CategoryCollection _unmodified_NodeSourceCategories;
	}
    [Table(Name = "RenderedNode")]
	public class RenderedNode
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string OriginalContentID { get; set; }
		// private string _unmodified_OriginalContentID;

		[Column]
		public string TechnicalSource { get; set; }
		// private string _unmodified_TechnicalSource;

		[Column]
		public string ImageBaseUrl { get; set; }
		// private string _unmodified_ImageBaseUrl;

		[Column]
		public string ImageExt { get; set; }
		// private string _unmodified_ImageExt;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string ActualContentUrl { get; set; }
		// private string _unmodified_ActualContentUrl;

		[Column]
		public string Excerpt { get; set; }
		// private string _unmodified_Excerpt;

		[Column]
		public string TimestampText { get; set; }
		// private string _unmodified_TimestampText;

		[Column]
		public string MainSortableText { get; set; }
		// private string _unmodified_MainSortableText;

		[Column]
		public bool IsCategoryFilteringNode { get; set; }
		// private bool _unmodified_IsCategoryFilteringNode;

		[Column]
		public ShortTextCollection CategoryFilters { get; set; }
		// private ShortTextCollection _unmodified_CategoryFilters;

		[Column]
		public ShortTextCollection CategoryNames { get; set; }
		// private ShortTextCollection _unmodified_CategoryNames;

		[Column]
		public ShortTextCollection Categories { get; set; }
		// private ShortTextCollection _unmodified_Categories;

		[Column]
		public string CategoryIDList { get; set; }
		// private string _unmodified_CategoryIDList;

		[Column]
		public ShortTextCollection Authors { get; set; }
		// private ShortTextCollection _unmodified_Authors;

		[Column]
		public ShortTextCollection Locations { get; set; }
		// private ShortTextCollection _unmodified_Locations;
	}
    [Table(Name = "ShortTextObject")]
	public class ShortTextObject
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Content { get; set; }
		// private string _unmodified_Content;
	}
    [Table(Name = "LongTextObject")]
	public class LongTextObject
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Content { get; set; }
		// private string _unmodified_Content;
	}
    [Table(Name = "MapContainer")]
	public class MapContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public Map MapFeatured { get; set; }
		// private Map _unmodified_MapFeatured;

		[Column]
		public MapCollection MapCollection { get; set; }
		// private MapCollection _unmodified_MapCollection;

		[Column]
		public MapResultCollection MapResultCollection { get; set; }
		// private MapResultCollection _unmodified_MapResultCollection;

		[Column]
		public MapIndexCollection MapIndexCollection { get; set; }
		// private MapIndexCollection _unmodified_MapIndexCollection;

		[Column]
		public AddressAndLocationCollection MarkerSourceLocations { get; set; }
		// private AddressAndLocationCollection _unmodified_MarkerSourceLocations;

		[Column]
		public BlogCollection MarkerSourceBlogs { get; set; }
		// private BlogCollection _unmodified_MarkerSourceBlogs;

		[Column]
		public ActivityCollection MarkerSourceActivities { get; set; }
		// private ActivityCollection _unmodified_MarkerSourceActivities;

		[Column]
		public MapMarkerCollection MapMarkers { get; set; }
		// private MapMarkerCollection _unmodified_MapMarkers;
	}
    [Table(Name = "MapMarker")]
	public class MapMarker
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string IconUrl { get; set; }
		// private string _unmodified_IconUrl;

		[Column]
		public string MarkerSource { get; set; }
		// private string _unmodified_MarkerSource;

		[Column]
		public string CategoryName { get; set; }
		// private string _unmodified_CategoryName;

		[Column]
		public string LocationText { get; set; }
		// private string _unmodified_LocationText;

		[Column]
		public string PopupTitle { get; set; }
		// private string _unmodified_PopupTitle;

		[Column]
		public string PopupContent { get; set; }
		// private string _unmodified_PopupContent;

		[Column]
		public Location Location { get; set; }
		// private Location _unmodified_Location;
	}
    [Table(Name = "CalendarContainer")]
	public class CalendarContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader CalendarContainerHeader { get; set; }
		// private ContainerHeader _unmodified_CalendarContainerHeader;

		[Column]
		public Calendar CalendarFeatured { get; set; }
		// private Calendar _unmodified_CalendarFeatured;

		[Column]
		public CalendarCollection CalendarCollection { get; set; }
		// private CalendarCollection _unmodified_CalendarCollection;

		[Column]
		public CalendarIndex CalendarIndexCollection { get; set; }
		// private CalendarIndex _unmodified_CalendarIndexCollection;
	}
    [Table(Name = "AboutContainer")]
	public class AboutContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image MainImage { get; set; }
		// private Image _unmodified_MainImage;

		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public string Excerpt { get; set; }
		// private string _unmodified_Excerpt;

		[Column]
		public string Body { get; set; }
		// private string _unmodified_Body;

		[Column]
		public DateTime Published { get; set; }
		// private DateTime _unmodified_Published;

		[Column]
		public string Author { get; set; }
		// private string _unmodified_Author;

		[Column]
		public ImageGroup ImageGroup { get; set; }
		// private ImageGroup _unmodified_ImageGroup;
	}
    [Table(Name = "OBSAccountContainer")]
	public class OBSAccountContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader AccountContainerHeader { get; set; }
		// private ContainerHeader _unmodified_AccountContainerHeader;

		[Column]
		public Calendar AccountFeatured { get; set; }
		// private Calendar _unmodified_AccountFeatured;

		[Column]
		public CalendarCollection AccountCollection { get; set; }
		// private CalendarCollection _unmodified_AccountCollection;

		[Column]
		public CalendarIndex AccountIndexCollection { get; set; }
		// private CalendarIndex _unmodified_AccountIndexCollection;
	}
    [Table(Name = "ProjectContainer")]
	public class ProjectContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader ProjectContainerHeader { get; set; }
		// private ContainerHeader _unmodified_ProjectContainerHeader;

		[Column]
		public Calendar ProjectFeatured { get; set; }
		// private Calendar _unmodified_ProjectFeatured;

		[Column]
		public CalendarCollection ProjectCollection { get; set; }
		// private CalendarCollection _unmodified_ProjectCollection;

		[Column]
		public CalendarIndex ProjectIndexCollection { get; set; }
		// private CalendarIndex _unmodified_ProjectIndexCollection;
	}
    [Table(Name = "CourseContainer")]
	public class CourseContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader CourseContainerHeader { get; set; }
		// private ContainerHeader _unmodified_CourseContainerHeader;

		[Column]
		public Calendar CourseFeatured { get; set; }
		// private Calendar _unmodified_CourseFeatured;

		[Column]
		public CalendarCollection CourseCollection { get; set; }
		// private CalendarCollection _unmodified_CourseCollection;

		[Column]
		public CalendarIndex CourseIndexCollection { get; set; }
		// private CalendarIndex _unmodified_CourseIndexCollection;
	}
    [Table(Name = "ContainerHeader")]
	public class ContainerHeader
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string SubTitle { get; set; }
		// private string _unmodified_SubTitle;
	}
    [Table(Name = "ActivitySummaryContainer")]
	public class ActivitySummaryContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public string SummaryBody { get; set; }
		// private string _unmodified_SummaryBody;

		[Column]
		public Introduction Introduction { get; set; }
		// private Introduction _unmodified_Introduction;

		[Column]
		public ActivityIndex ActivityIndex { get; set; }
		// private ActivityIndex _unmodified_ActivityIndex;

		[Column]
		public ActivityCollection ActivityCollection { get; set; }
		// private ActivityCollection _unmodified_ActivityCollection;
	}
    [Table(Name = "ActivityIndex")]
	public class ActivityIndex
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image Icon { get; set; }
		// private Image _unmodified_Icon;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Introduction { get; set; }
		// private string _unmodified_Introduction;

		[Column]
		public string Summary { get; set; }
		// private string _unmodified_Summary;
	}
    [Table(Name = "ActivityContainer")]
	public class ActivityContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public ActivityIndex ActivityIndex { get; set; }
		// private ActivityIndex _unmodified_ActivityIndex;

		[Column]
		public Activity ActivityModule { get; set; }
		// private Activity _unmodified_ActivityModule;
	}
    [Table(Name = "Activity")]
	public class Activity
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public Image ProfileImage { get; set; }
		// private Image _unmodified_ProfileImage;

		[Column]
		public Image IconImage { get; set; }
		// private Image _unmodified_IconImage;

		[Column]
		public string ActivityName { get; set; }
		// private string _unmodified_ActivityName;

		[Column]
		public Introduction Introduction { get; set; }
		// private Introduction _unmodified_Introduction;

		[Column]
		public string ContactPerson { get; set; }
		// private string _unmodified_ContactPerson;

		[Column]
		public DateTime StartingTime { get; set; }
		// private DateTime _unmodified_StartingTime;

		[Column]
		public string Excerpt { get; set; }
		// private string _unmodified_Excerpt;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public string IFrameSources { get; set; }
		// private string _unmodified_IFrameSources;

		[Column]
		public CollaboratorCollection Collaborators { get; set; }
		// private CollaboratorCollection _unmodified_Collaborators;

		[Column]
		public ImageGroupCollection ImageGroupCollection { get; set; }
		// private ImageGroupCollection _unmodified_ImageGroupCollection;

		[Column]
		public AddressAndLocationCollection LocationCollection { get; set; }
		// private AddressAndLocationCollection _unmodified_LocationCollection;

		[Column]
		public CategoryCollection CategoryCollection { get; set; }
		// private CategoryCollection _unmodified_CategoryCollection;
	}
    [Table(Name = "Moderator")]
	public class Moderator
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ModeratorName { get; set; }
		// private string _unmodified_ModeratorName;

		[Column]
		public string ProfileUrl { get; set; }
		// private string _unmodified_ProfileUrl;
	}
    [Table(Name = "Collaborator")]
	public class Collaborator
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string AccountID { get; set; }
		// private string _unmodified_AccountID;

		[Column]
		public string EmailAddress { get; set; }
		// private string _unmodified_EmailAddress;

		[Column]
		public string CollaboratorName { get; set; }
		// private string _unmodified_CollaboratorName;

		[Column]
		public string Role { get; set; }
		// private string _unmodified_Role;

		[Column]
		public string ProfileUrl { get; set; }
		// private string _unmodified_ProfileUrl;
	}
    [Table(Name = "GroupSummaryContainer")]
	public class GroupSummaryContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public string SummaryBody { get; set; }
		// private string _unmodified_SummaryBody;

		[Column]
		public Introduction Introduction { get; set; }
		// private Introduction _unmodified_Introduction;

		[Column]
		public GroupIndex GroupSummaryIndex { get; set; }
		// private GroupIndex _unmodified_GroupSummaryIndex;

		[Column]
		public GroupCollection GroupCollection { get; set; }
		// private GroupCollection _unmodified_GroupCollection;
	}
    [Table(Name = "GroupContainer")]
	public class GroupContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ContainerHeader Header { get; set; }
		// private ContainerHeader _unmodified_Header;

		[Column]
		public GroupIndex GroupIndex { get; set; }
		// private GroupIndex _unmodified_GroupIndex;

		[Column]
		public Group GroupProfile { get; set; }
		// private Group _unmodified_GroupProfile;

		[Column]
		public CollaboratorCollection Collaborators { get; set; }
		// private CollaboratorCollection _unmodified_Collaborators;

		[Column]
		public CollaboratorCollection PendingCollaborators { get; set; }
		// private CollaboratorCollection _unmodified_PendingCollaborators;

		[Column]
		public ActivityCollection Activities { get; set; }
		// private ActivityCollection _unmodified_Activities;

		[Column]
		public ImageGroupCollection ImageGroupCollection { get; set; }
		// private ImageGroupCollection _unmodified_ImageGroupCollection;

		[Column]
		public AddressAndLocationCollection LocationCollection { get; set; }
		// private AddressAndLocationCollection _unmodified_LocationCollection;
	}
    [Table(Name = "GroupIndex")]
	public class GroupIndex
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image Icon { get; set; }
		// private Image _unmodified_Icon;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Introduction { get; set; }
		// private string _unmodified_Introduction;

		[Column]
		public string Summary { get; set; }
		// private string _unmodified_Summary;
	}
    [Table(Name = "AddAddressAndLocationInfo")]
	public class AddAddressAndLocationInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string LocationName { get; set; }
		// private string _unmodified_LocationName;
	}
    [Table(Name = "AddImageInfo")]
	public class AddImageInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ImageTitle { get; set; }
		// private string _unmodified_ImageTitle;
	}
    [Table(Name = "AddImageGroupInfo")]
	public class AddImageGroupInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ImageGroupTitle { get; set; }
		// private string _unmodified_ImageGroupTitle;
	}
    [Table(Name = "AddEmailAddressInfo")]
	public class AddEmailAddressInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string EmailAddress { get; set; }
		// private string _unmodified_EmailAddress;
	}
    [Table(Name = "CreateGroupInfo")]
	public class CreateGroupInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string GroupName { get; set; }
		// private string _unmodified_GroupName;
	}
    [Table(Name = "AddActivityInfo")]
	public class AddActivityInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ActivityName { get; set; }
		// private string _unmodified_ActivityName;
	}
    [Table(Name = "AddBlogPostInfo")]
	public class AddBlogPostInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;
	}
    [Table(Name = "AddCategoryInfo")]
	public class AddCategoryInfo
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string CategoryName { get; set; }
		// private string _unmodified_CategoryName;
	}
    [Table(Name = "Group")]
	public class Group
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public Image ProfileImage { get; set; }
		// private Image _unmodified_ProfileImage;

		[Column]
		public Image IconImage { get; set; }
		// private Image _unmodified_IconImage;

		[Column]
		public string GroupName { get; set; }
		// private string _unmodified_GroupName;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public string OrganizationsAndGroupsLinkedToUs { get; set; }
		// private string _unmodified_OrganizationsAndGroupsLinkedToUs;

		[Column]
		public string WwwSiteToPublishTo { get; set; }
		// private string _unmodified_WwwSiteToPublishTo;

		[Column]
		public ShortTextCollection CustomUICollection { get; set; }
		// private ShortTextCollection _unmodified_CustomUICollection;

		[Column]
		public ModeratorCollection Moderators { get; set; }
		// private ModeratorCollection _unmodified_Moderators;

		[Column]
		public CategoryCollection CategoryCollection { get; set; }
		// private CategoryCollection _unmodified_CategoryCollection;
	}
    [Table(Name = "Introduction")]
	public class Introduction
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Body { get; set; }
		// private string _unmodified_Body;
	}
    [Table(Name = "ContentCategoryRank")]
	public class ContentCategoryRank
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ContentID { get; set; }
		// private string _unmodified_ContentID;

		[Column]
		public string ContentSemanticType { get; set; }
		// private string _unmodified_ContentSemanticType;

		[Column]
		public string CategoryID { get; set; }
		// private string _unmodified_CategoryID;

		[Column]
		public string RankName { get; set; }
		// private string _unmodified_RankName;

		[Column]
		public string RankValue { get; set; }
		// private string _unmodified_RankValue;
	}
    [Table(Name = "LinkToContent")]
	public class LinkToContent
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string URL { get; set; }
		// private string _unmodified_URL;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public DateTime Published { get; set; }
		// private DateTime _unmodified_Published;

		[Column]
		public string Author { get; set; }
		// private string _unmodified_Author;

		[Column]
		public MediaContent ImageData { get; set; }
		// private MediaContent _unmodified_ImageData;

		[Column]
		public AddressAndLocationCollection Locations { get; set; }
		// private AddressAndLocationCollection _unmodified_Locations;

		[Column]
		public CategoryCollection Categories { get; set; }
		// private CategoryCollection _unmodified_Categories;
	}
    [Table(Name = "EmbeddedContent")]
	public class EmbeddedContent
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string IFrameTagContents { get; set; }
		// private string _unmodified_IFrameTagContents;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public DateTime Published { get; set; }
		// private DateTime _unmodified_Published;

		[Column]
		public string Author { get; set; }
		// private string _unmodified_Author;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public AddressAndLocationCollection Locations { get; set; }
		// private AddressAndLocationCollection _unmodified_Locations;

		[Column]
		public CategoryCollection Categories { get; set; }
		// private CategoryCollection _unmodified_Categories;
	}
    [Table(Name = "DynamicContentGroup")]
	public class DynamicContentGroup
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string HostName { get; set; }
		// private string _unmodified_HostName;

		[Column]
		public string GroupHeader { get; set; }
		// private string _unmodified_GroupHeader;

		[Column]
		public string SortValue { get; set; }
		// private string _unmodified_SortValue;

		[Column]
		public string PageLocation { get; set; }
		// private string _unmodified_PageLocation;

		[Column]
		public string ContentItemNames { get; set; }
		// private string _unmodified_ContentItemNames;
	}
    [Table(Name = "DynamicContent")]
	public class DynamicContent
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string HostName { get; set; }
		// private string _unmodified_HostName;

		[Column]
		public string ContentName { get; set; }
		// private string _unmodified_ContentName;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public string ElementQuery { get; set; }
		// private string _unmodified_ElementQuery;

		[Column]
		public string Content { get; set; }
		// private string _unmodified_Content;

		[Column]
		public string RawContent { get; set; }
		// private string _unmodified_RawContent;

		[Column]
		public MediaContent ImageData { get; set; }
		// private MediaContent _unmodified_ImageData;

		[Column]
		public bool IsEnabled { get; set; }
		// private bool _unmodified_IsEnabled;

		[Column]
		public bool ApplyActively { get; set; }
		// private bool _unmodified_ApplyActively;

		[Column]
		public string EditType { get; set; }
		// private string _unmodified_EditType;

		[Column]
		public string PageLocation { get; set; }
		// private string _unmodified_PageLocation;
	}
    [Table(Name = "AttachedToObject")]
	public class AttachedToObject
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string SourceObjectID { get; set; }
		// private string _unmodified_SourceObjectID;

		[Column]
		public string SourceObjectName { get; set; }
		// private string _unmodified_SourceObjectName;

		[Column]
		public string SourceObjectDomain { get; set; }
		// private string _unmodified_SourceObjectDomain;

		[Column]
		public string TargetObjectID { get; set; }
		// private string _unmodified_TargetObjectID;

		[Column]
		public string TargetObjectName { get; set; }
		// private string _unmodified_TargetObjectName;

		[Column]
		public string TargetObjectDomain { get; set; }
		// private string _unmodified_TargetObjectDomain;
	}
    [Table(Name = "Comment")]
	public class Comment
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string TargetObjectID { get; set; }
		// private string _unmodified_TargetObjectID;

		[Column]
		public string TargetObjectName { get; set; }
		// private string _unmodified_TargetObjectName;

		[Column]
		public string TargetObjectDomain { get; set; }
		// private string _unmodified_TargetObjectDomain;

		[Column]
		public string CommentText { get; set; }
		// private string _unmodified_CommentText;

		[Column]
		public DateTime Created { get; set; }
		// private DateTime _unmodified_Created;

		[Column]
		public string OriginalAuthorName { get; set; }
		// private string _unmodified_OriginalAuthorName;

		[Column]
		public string OriginalAuthorEmail { get; set; }
		// private string _unmodified_OriginalAuthorEmail;

		[Column]
		public string OriginalAuthorAccountID { get; set; }
		// private string _unmodified_OriginalAuthorAccountID;

		[Column]
		public DateTime LastModified { get; set; }
		// private DateTime _unmodified_LastModified;

		[Column]
		public string LastAuthorName { get; set; }
		// private string _unmodified_LastAuthorName;

		[Column]
		public string LastAuthorEmail { get; set; }
		// private string _unmodified_LastAuthorEmail;

		[Column]
		public string LastAuthorAccountID { get; set; }
		// private string _unmodified_LastAuthorAccountID;
	}
    [Table(Name = "Selection")]
	public class Selection
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string TargetObjectID { get; set; }
		// private string _unmodified_TargetObjectID;

		[Column]
		public string TargetObjectName { get; set; }
		// private string _unmodified_TargetObjectName;

		[Column]
		public string TargetObjectDomain { get; set; }
		// private string _unmodified_TargetObjectDomain;

		[Column]
		public string SelectionCategory { get; set; }
		// private string _unmodified_SelectionCategory;

		[Column]
		public string TextValue { get; set; }
		// private string _unmodified_TextValue;

		[Column]
		public bool BooleanValue { get; set; }
		// private bool _unmodified_BooleanValue;

		[Column]
		public double DoubleValue { get; set; }
		// private double _unmodified_DoubleValue;
	}
    [Table(Name = "TextContent")]
	public class TextContent
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public MediaContent ImageData { get; set; }
		// private MediaContent _unmodified_ImageData;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string SubTitle { get; set; }
		// private string _unmodified_SubTitle;

		[Column]
		public DateTime Published { get; set; }
		// private DateTime _unmodified_Published;

		[Column]
		public string Author { get; set; }
		// private string _unmodified_Author;

		[Column]
		public string Excerpt { get; set; }
		// private string _unmodified_Excerpt;

		[Column]
		public string Body { get; set; }
		// private string _unmodified_Body;

		[Column]
		public AddressAndLocationCollection Locations { get; set; }
		// private AddressAndLocationCollection _unmodified_Locations;

		[Column]
		public CategoryCollection Categories { get; set; }
		// private CategoryCollection _unmodified_Categories;

		[Column]
		public double SortOrderNumber { get; set; }
		// private double _unmodified_SortOrderNumber;

		[Column]
		public string IFrameSources { get; set; }
		// private string _unmodified_IFrameSources;

		[Column]
		public string RawHtmlContent { get; set; }
		// private string _unmodified_RawHtmlContent;
	}
    [Table(Name = "Blog")]
	public class Blog
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public Image ProfileImage { get; set; }
		// private Image _unmodified_ProfileImage;

		[Column]
		public Image IconImage { get; set; }
		// private Image _unmodified_IconImage;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string SubTitle { get; set; }
		// private string _unmodified_SubTitle;

		[Column]
		public Introduction Introduction { get; set; }
		// private Introduction _unmodified_Introduction;

		[Column]
		public DateTime Published { get; set; }
		// private DateTime _unmodified_Published;

		[Column]
		public string Author { get; set; }
		// private string _unmodified_Author;

		[Column]
		public Image FeaturedImage { get; set; }
		// private Image _unmodified_FeaturedImage;

		[Column]
		public ImageGroupCollection ImageGroupCollection { get; set; }
		// private ImageGroupCollection _unmodified_ImageGroupCollection;

		[Column]
		public VideoGroup VideoGroup { get; set; }
		// private VideoGroup _unmodified_VideoGroup;

		[Column]
		public string Body { get; set; }
		// private string _unmodified_Body;

		[Column]
		public string Excerpt { get; set; }
		// private string _unmodified_Excerpt;

		[Column]
		public string IFrameSources { get; set; }
		// private string _unmodified_IFrameSources;

		[Column]
		public AddressAndLocationCollection LocationCollection { get; set; }
		// private AddressAndLocationCollection _unmodified_LocationCollection;

		[Column]
		public CategoryCollection CategoryCollection { get; set; }
		// private CategoryCollection _unmodified_CategoryCollection;

		[Column]
		public SocialPanelCollection SocialPanel { get; set; }
		// private SocialPanelCollection _unmodified_SocialPanel;
	}
    [Table(Name = "BlogIndexGroup")]
	public class BlogIndexGroup
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image Icon { get; set; }
		// private Image _unmodified_Icon;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Introduction { get; set; }
		// private string _unmodified_Introduction;

		[Column]
		public GroupedInformationCollection GroupedByDate { get; set; }
		// private GroupedInformationCollection _unmodified_GroupedByDate;

		[Column]
		public GroupedInformationCollection GroupedByLocation { get; set; }
		// private GroupedInformationCollection _unmodified_GroupedByLocation;

		[Column]
		public GroupedInformationCollection GroupedByAuthor { get; set; }
		// private GroupedInformationCollection _unmodified_GroupedByAuthor;

		[Column]
		public GroupedInformationCollection GroupedByCategory { get; set; }
		// private GroupedInformationCollection _unmodified_GroupedByCategory;

		[Column]
		public ReferenceCollection FullBlogArchive { get; set; }
		// private ReferenceCollection _unmodified_FullBlogArchive;

		[Column]
		public BlogCollection BlogSourceForSummary { get; set; }
		// private BlogCollection _unmodified_BlogSourceForSummary;

		[Column]
		public string Summary { get; set; }
		// private string _unmodified_Summary;
	}
    [Table(Name = "CalendarIndex")]
	public class CalendarIndex
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Image Icon { get; set; }
		// private Image _unmodified_Icon;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Introduction { get; set; }
		// private string _unmodified_Introduction;

		[Column]
		public string Summary { get; set; }
		// private string _unmodified_Summary;
	}
    [Table(Name = "Filter")]
	public class Filter
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;
	}
    [Table(Name = "Calendar")]
	public class Calendar
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;
	}
    [Table(Name = "Map")]
	public class Map
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;
	}
    [Table(Name = "MapIndexCollection")]
	public class MapIndexCollection
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public MapCollection MapByDate { get; set; }
		// private MapCollection _unmodified_MapByDate;

		[Column]
		public MapCollection MapByLocation { get; set; }
		// private MapCollection _unmodified_MapByLocation;

		[Column]
		public MapCollection MapByAuthor { get; set; }
		// private MapCollection _unmodified_MapByAuthor;

		[Column]
		public MapCollection MapByCategory { get; set; }
		// private MapCollection _unmodified_MapByCategory;
	}
    [Table(Name = "MapResult")]
	public class MapResult
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Location Location { get; set; }
		// private Location _unmodified_Location;
	}
    [Table(Name = "MapResultsCollection")]
	public class MapResultsCollection
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public MapResultCollection ResultByDate { get; set; }
		// private MapResultCollection _unmodified_ResultByDate;

		[Column]
		public MapResultCollection ResultByAuthor { get; set; }
		// private MapResultCollection _unmodified_ResultByAuthor;

		[Column]
		public MapResultCollection ResultByProximity { get; set; }
		// private MapResultCollection _unmodified_ResultByProximity;
	}
    [Table(Name = "Video")]
	public class Video
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public MediaContent VideoData { get; set; }
		// private MediaContent _unmodified_VideoData;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Caption { get; set; }
		// private string _unmodified_Caption;
	}
    [Table(Name = "Image")]
	public class Image
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public MediaContent ImageData { get; set; }
		// private MediaContent _unmodified_ImageData;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Caption { get; set; }
		// private string _unmodified_Caption;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public AddressAndLocationCollection Locations { get; set; }
		// private AddressAndLocationCollection _unmodified_Locations;

		[Column]
		public CategoryCollection Categories { get; set; }
		// private CategoryCollection _unmodified_Categories;
	}
    [Table(Name = "BinaryFile")]
	public class BinaryFile
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string OriginalFileName { get; set; }
		// private string _unmodified_OriginalFileName;

		[Column]
		public MediaContent Data { get; set; }
		// private MediaContent _unmodified_Data;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public CategoryCollection Categories { get; set; }
		// private CategoryCollection _unmodified_Categories;
	}
    [Table(Name = "ImageGroup")]
	public class ImageGroup
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public Image FeaturedImage { get; set; }
		// private Image _unmodified_FeaturedImage;

		[Column]
		public ImageCollection ImagesCollection { get; set; }
		// private ImageCollection _unmodified_ImagesCollection;
	}
    [Table(Name = "VideoGroup")]
	public class VideoGroup
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;

		[Column]
		public VideoCollection VideoCollection { get; set; }
		// private VideoCollection _unmodified_VideoCollection;
	}
    [Table(Name = "Tooltip")]
	public class Tooltip
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string TooltipText { get; set; }
		// private string _unmodified_TooltipText;
	}
    [Table(Name = "SocialPanel")]
	public class SocialPanel
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Filter SocialFilter { get; set; }
		// private Filter _unmodified_SocialFilter;
	}
    [Table(Name = "Longitude")]
	public class Longitude
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string TextValue { get; set; }
		// private string _unmodified_TextValue;
	}
    [Table(Name = "Latitude")]
	public class Latitude
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string TextValue { get; set; }
		// private string _unmodified_TextValue;
	}
    [Table(Name = "Location")]
	public class Location
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string LocationName { get; set; }
		// private string _unmodified_LocationName;

		[Column]
		public Longitude Longitude { get; set; }
		// private Longitude _unmodified_Longitude;

		[Column]
		public Latitude Latitude { get; set; }
		// private Latitude _unmodified_Latitude;
	}
    [Table(Name = "Date")]
	public class Date
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public DateTime Day { get; set; }
		// private DateTime _unmodified_Day;

		[Column]
		public DateTime Week { get; set; }
		// private DateTime _unmodified_Week;

		[Column]
		public DateTime Month { get; set; }
		// private DateTime _unmodified_Month;

		[Column]
		public DateTime Year { get; set; }
		// private DateTime _unmodified_Year;
	}
    [Table(Name = "Sex")]
	public class Sex
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string SexText { get; set; }
		// private string _unmodified_SexText;
	}
    [Table(Name = "OBSAddress")]
	public class OBSAddress
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string StreetName { get; set; }
		// private string _unmodified_StreetName;

		[Column]
		public string BuildingNumber { get; set; }
		// private string _unmodified_BuildingNumber;

		[Column]
		public string PostOfficeBox { get; set; }
		// private string _unmodified_PostOfficeBox;

		[Column]
		public string PostalCode { get; set; }
		// private string _unmodified_PostalCode;

		[Column]
		public string Municipality { get; set; }
		// private string _unmodified_Municipality;

		[Column]
		public string Region { get; set; }
		// private string _unmodified_Region;

		[Column]
		public string Province { get; set; }
		// private string _unmodified_Province;

		[Column]
		public string state { get; set; }
		// private string _unmodified_state;

		[Column]
		public string Country { get; set; }
		// private string _unmodified_Country;

		[Column]
		public string Continent { get; set; }
		// private string _unmodified_Continent;
	}
    [Table(Name = "Identity")]
	public class Identity
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string FirstName { get; set; }
		// private string _unmodified_FirstName;

		[Column]
		public string LastName { get; set; }
		// private string _unmodified_LastName;

		[Column]
		public string Initials { get; set; }
		// private string _unmodified_Initials;

		[Column]
		public Sex Sex { get; set; }
		// private Sex _unmodified_Sex;

		[Column]
		public Date Birthday { get; set; }
		// private Date _unmodified_Birthday;
	}
    [Table(Name = "ImageVideoSoundVectorRaw")]
	public class ImageVideoSoundVectorRaw
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public byte[] Image { get; set; }
		// private byte[] _unmodified_Image;

		[Column]
		public byte[] Video { get; set; }
		// private byte[] _unmodified_Video;

		[Column]
		public byte[] Sound { get; set; }
		// private byte[] _unmodified_Sound;

		[Column]
		public string Vector { get; set; }
		// private string _unmodified_Vector;

		[Column]
		public byte[] Raw { get; set; }
		// private byte[] _unmodified_Raw;
	}
    [Table(Name = "CategoryContainer")]
	public class CategoryContainer
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public CategoryCollection Categories { get; set; }
		// private CategoryCollection _unmodified_Categories;
	}
    [Table(Name = "Category")]
	public class Category
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public ReferenceToInformation ReferenceToInformation { get; set; }
		// private ReferenceToInformation _unmodified_ReferenceToInformation;

		[Column]
		public string CategoryName { get; set; }
		// private string _unmodified_CategoryName;

		[Column]
		public MediaContent ImageData { get; set; }
		// private MediaContent _unmodified_ImageData;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Excerpt { get; set; }
		// private string _unmodified_Excerpt;

		[Column]
		public Category ParentCategory { get; set; }
		// private Category _unmodified_ParentCategory;

		[Column]
		public string ParentCategoryID { get; set; }
		// private string _unmodified_ParentCategoryID;
	}
    [Table(Name = "Subscription")]
	public class Subscription
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public long Priority { get; set; }
		// private long _unmodified_Priority;

		[Column]
		public string TargetRelativeLocation { get; set; }
		// private string _unmodified_TargetRelativeLocation;

		[Column]
		public string TargetInformationObjectType { get; set; }
		// private string _unmodified_TargetInformationObjectType;

		[Column]
		public string SubscriberRelativeLocation { get; set; }
		// private string _unmodified_SubscriberRelativeLocation;

		[Column]
		public string SubscriberInformationObjectType { get; set; }
		// private string _unmodified_SubscriberInformationObjectType;

		[Column]
		public string SubscriptionType { get; set; }
		// private string _unmodified_SubscriptionType;
	}
    [Table(Name = "QueueEnvelope")]
	public class QueueEnvelope
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ActiveContainerName { get; set; }
		// private string _unmodified_ActiveContainerName;

		[Column]
		public string OwnerPrefix { get; set; }
		// private string _unmodified_OwnerPrefix;

		[Column]
		public long CurrentRetryCount { get; set; }
		// private long _unmodified_CurrentRetryCount;

		[Column]
		public OperationRequest SingleOperation { get; set; }
		// private OperationRequest _unmodified_SingleOperation;

		[Column]
		public OperationRequestCollection OrderDependentOperationSequence { get; set; }
		// private OperationRequestCollection _unmodified_OrderDependentOperationSequence;

		[Column]
		public SystemError ErrorContent { get; set; }
		// private SystemError _unmodified_ErrorContent;
	}
    [Table(Name = "OperationRequest")]
	public class OperationRequest
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public Subscription SubscriberNotification { get; set; }
		// private Subscription _unmodified_SubscriberNotification;

		[Column]
		public SubscriptionChainRequestMessage SubscriptionChainRequest { get; set; }
		// private SubscriptionChainRequestMessage _unmodified_SubscriptionChainRequest;

		[Column]
		public UpdateWebContentOperation UpdateWebContentOperation { get; set; }
		// private UpdateWebContentOperation _unmodified_UpdateWebContentOperation;

		[Column]
		public RefreshDefaultViewsOperation RefreshDefaultViewsOperation { get; set; }
		// private RefreshDefaultViewsOperation _unmodified_RefreshDefaultViewsOperation;

		[Column]
		public DeleteEntireOwnerOperation DeleteEntireOwner { get; set; }
		// private DeleteEntireOwnerOperation _unmodified_DeleteEntireOwner;

		[Column]
		public DeleteOwnerContentOperation DeleteOwnerContent { get; set; }
		// private DeleteOwnerContentOperation _unmodified_DeleteOwnerContent;

		[Column]
		public PublishWebContentOperation PublishWebContent { get; set; }
		// private PublishWebContentOperation _unmodified_PublishWebContent;

		[Column]
		public string ProcessIDToExecute { get; set; }
		// private string _unmodified_ProcessIDToExecute;
	}
    [Table(Name = "SubscriptionChainRequestMessage")]
	public class SubscriptionChainRequestMessage
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ContentItemID { get; set; }
		// private string _unmodified_ContentItemID;
	}
    [Table(Name = "SubscriptionChainRequestContent")]
	public class SubscriptionChainRequestContent
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public DateTime SubmitTime { get; set; }
		// private DateTime _unmodified_SubmitTime;

		[Column]
		public DateTime ProcessingStartTime { get; set; }
		// private DateTime _unmodified_ProcessingStartTime;

		[Column]
		public DateTime ProcessingEndTimeInformationObjects { get; set; }
		// private DateTime _unmodified_ProcessingEndTimeInformationObjects;

		[Column]
		public DateTime ProcessingEndTimeWebTemplatesRendering { get; set; }
		// private DateTime _unmodified_ProcessingEndTimeWebTemplatesRendering;

		[Column]
		public DateTime ProcessingEndTime { get; set; }
		// private DateTime _unmodified_ProcessingEndTime;

		[Column]
		public SubscriptionTargetCollection SubscriptionTargetCollection { get; set; }
		// private SubscriptionTargetCollection _unmodified_SubscriptionTargetCollection;
	}
    [Table(Name = "SubscriptionTarget")]
	public class SubscriptionTarget
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string BlobLocation { get; set; }
		// private string _unmodified_BlobLocation;
	}
    [Table(Name = "DeleteEntireOwnerOperation")]
	public class DeleteEntireOwnerOperation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ContainerName { get; set; }
		// private string _unmodified_ContainerName;

		[Column]
		public string LocationPrefix { get; set; }
		// private string _unmodified_LocationPrefix;
	}
    [Table(Name = "DeleteOwnerContentOperation")]
	public class DeleteOwnerContentOperation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ContainerName { get; set; }
		// private string _unmodified_ContainerName;

		[Column]
		public string LocationPrefix { get; set; }
		// private string _unmodified_LocationPrefix;
	}
    [Table(Name = "SystemError")]
	public class SystemError
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ErrorTitle { get; set; }
		// private string _unmodified_ErrorTitle;

		[Column]
		public DateTime OccurredAt { get; set; }
		// private DateTime _unmodified_OccurredAt;

		[Column]
		public SystemErrorItemCollection SystemErrorItems { get; set; }
		// private SystemErrorItemCollection _unmodified_SystemErrorItems;

		[Column]
		public QueueEnvelope MessageContent { get; set; }
		// private QueueEnvelope _unmodified_MessageContent;
	}
    [Table(Name = "SystemErrorItem")]
	public class SystemErrorItem
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ShortDescription { get; set; }
		// private string _unmodified_ShortDescription;

		[Column]
		public string LongDescription { get; set; }
		// private string _unmodified_LongDescription;
	}
    [Table(Name = "InformationSource")]
	public class InformationSource
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string SourceName { get; set; }
		// private string _unmodified_SourceName;

		[Column]
		public string SourceLocation { get; set; }
		// private string _unmodified_SourceLocation;

		[Column]
		public string SourceType { get; set; }
		// private string _unmodified_SourceType;

		[Column]
		public bool IsDynamic { get; set; }
		// private bool _unmodified_IsDynamic;

		[Column]
		public string SourceInformationObjectType { get; set; }
		// private string _unmodified_SourceInformationObjectType;

		[Column]
		public string SourceETag { get; set; }
		// private string _unmodified_SourceETag;

		[Column]
		public string SourceMD5 { get; set; }
		// private string _unmodified_SourceMD5;

		[Column]
		public DateTime SourceLastModified { get; set; }
		// private DateTime _unmodified_SourceLastModified;
	}
    [Table(Name = "RefreshDefaultViewsOperation")]
	public class RefreshDefaultViewsOperation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string ViewLocation { get; set; }
		// private string _unmodified_ViewLocation;

		[Column]
		public string TypeNameToRefresh { get; set; }
		// private string _unmodified_TypeNameToRefresh;
	}
    [Table(Name = "UpdateWebContentOperation")]
	public class UpdateWebContentOperation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string SourceContainerName { get; set; }
		// private string _unmodified_SourceContainerName;

		[Column]
		public string SourcePathRoot { get; set; }
		// private string _unmodified_SourcePathRoot;

		[Column]
		public string TargetContainerName { get; set; }
		// private string _unmodified_TargetContainerName;

		[Column]
		public string TargetPathRoot { get; set; }
		// private string _unmodified_TargetPathRoot;

		[Column]
		public bool RenderWhileSync { get; set; }
		// private bool _unmodified_RenderWhileSync;

		[Column]
		public UpdateWebContentHandlerCollection Handlers { get; set; }
		// private UpdateWebContentHandlerCollection _unmodified_Handlers;
	}
    [Table(Name = "UpdateWebContentHandlerItem")]
	public class UpdateWebContentHandlerItem
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string InformationTypeName { get; set; }
		// private string _unmodified_InformationTypeName;

		[Column]
		public string OptionName { get; set; }
		// private string _unmodified_OptionName;
	}
    [Table(Name = "PublishWebContentOperation")]
	public class PublishWebContentOperation
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string SourceContainerName { get; set; }
		// private string _unmodified_SourceContainerName;

		[Column]
		public string SourcePathRoot { get; set; }
		// private string _unmodified_SourcePathRoot;

		[Column]
		public string SourceOwner { get; set; }
		// private string _unmodified_SourceOwner;

		[Column]
		public string TargetContainerName { get; set; }
		// private string _unmodified_TargetContainerName;
	}
    [Table(Name = "SubscriberInput")]
	public class SubscriberInput
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string InputRelativeLocation { get; set; }
		// private string _unmodified_InputRelativeLocation;

		[Column]
		public string InformationObjectName { get; set; }
		// private string _unmodified_InformationObjectName;

		[Column]
		public string InformationItemName { get; set; }
		// private string _unmodified_InformationItemName;

		[Column]
		public string SubscriberRelativeLocation { get; set; }
		// private string _unmodified_SubscriberRelativeLocation;
	}
    [Table(Name = "Monitor")]
	public class Monitor
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public string TargetObjectName { get; set; }
		// private string _unmodified_TargetObjectName;

		[Column]
		public string TargetItemName { get; set; }
		// private string _unmodified_TargetItemName;

		[Column]
		public DateTime MonitoringUtcTimeStampToStart { get; set; }
		// private DateTime _unmodified_MonitoringUtcTimeStampToStart;

		[Column]
		public string MonitoringCycleFrequencyUnit { get; set; }
		// private string _unmodified_MonitoringCycleFrequencyUnit;

		[Column]
		public long MonitoringCycleEveryXthOfUnit { get; set; }
		// private long _unmodified_MonitoringCycleEveryXthOfUnit;

		[Column]
		public string CustomMonitoringCycleOperationName { get; set; }
		// private string _unmodified_CustomMonitoringCycleOperationName;

		[Column]
		public string OperationActionName { get; set; }
		// private string _unmodified_OperationActionName;
	}
    [Table(Name = "IconTitleDescription")]
	public class IconTitleDescription
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public byte[] Icon { get; set; }
		// private byte[] _unmodified_Icon;

		[Column]
		public string Title { get; set; }
		// private string _unmodified_Title;

		[Column]
		public string Description { get; set; }
		// private string _unmodified_Description;
	}
    [Table(Name = "AboutAGIApplications")]
	public class AboutAGIApplications
	{
		[Column]
		public string ID { get; set; }


		[Column]
		public IconTitleDescription BuiltForAnybody { get; set; }
		// private IconTitleDescription _unmodified_BuiltForAnybody;

		[Column]
		public IconTitleDescription ForAllPeople { get; set; }
		// private IconTitleDescription _unmodified_ForAllPeople;
	}
 } 