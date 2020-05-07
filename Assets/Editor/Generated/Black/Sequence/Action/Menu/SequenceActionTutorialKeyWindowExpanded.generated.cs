using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionTutorialKeyWindowExpanded : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin opend_;
		public float dispTime_;
		public int maskType_;
		public int messageSpecificationType0_;
		public uint dialogFixId0_;
		public string dialogString0_;
		public int messageSpecificationType1_;
		public uint dialogFixId1_;
		public string dialogString1_;
		public int messageSpecificationType2_;
		public uint dialogFixId2_;
		public string dialogString2_;
		public int messageSpecificationType3_;
		public uint dialogFixId3_;
		public string dialogString3_;
		public int messageSpecificationType4_;
		public uint dialogFixId4_;
		public string dialogString4_;
		public int messageSpecificationType5_;
		public uint dialogFixId5_;
		public string dialogString5_;
		public int messageSpecificationType6_;
		public uint dialogFixId6_;
		public string dialogString6_;
		public int messageSpecificationType7_;
		public uint dialogFixId7_;
		public string dialogString7_;
		public int messageSpecificationType8_;
		public uint dialogFixId8_;
		public string dialogString8_;
		public int messageSpecificationType9_;
		public uint dialogFixId9_;
		public string dialogString9_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTutorialKeyWindowExpanded();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionTutorialKeyWindowExpanded", 0, Black.Sequence.Action.Menu.SequenceActionTutorialKeyWindowExpanded.ObjectType, null, properties, 0, 920);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionTutorialKeyWindowExpanded", base.GetFieldProperties(), 1137473737, 1507390830);
            
			
			
			return fieldProperties;
        }

		
    }
}