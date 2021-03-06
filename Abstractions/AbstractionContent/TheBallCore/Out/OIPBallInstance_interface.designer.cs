 


namespace AaltoGlobalImpact.OIP { 
		
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Xml;
using System.Linq;
using System.Runtime.Serialization;



			[DataContract]
			public partial class CategoryChildRanking 
			{
				[DataMember]
				public string ID { get; set; }

			    [IgnoreDataMember]
                public string ETag { get; set; }

			[DataMember]
			public string CategoryID;

			[DataMember]
			public List<RankingItem> RankingItems= new List<RankingItem>();

			
			}
			[DataContract]
			public partial class RankingItem 
			{
				[DataMember]
				public string ID { get; set; }

			    [IgnoreDataMember]
                public string ETag { get; set; }

			[DataMember]
			public string ContentID;

			[DataMember]
			public string ContentSemanticType;

			[DataMember]
			public string RankName;

			[DataMember]
			public string RankValue;

			
			}
			[DataContract]
			public partial class ParentToChildren 
			{
				[DataMember]
				public string ID { get; set; }

			    [IgnoreDataMember]
                public string ETag { get; set; }

			[DataMember]
			public string id;

			[DataMember]
			public List<ParentToChildren> children= new List<ParentToChildren>();

			
			}
 } 