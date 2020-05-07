using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionTutorialKeyInfoWindow : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin opend_;
		public float dispTime_;
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
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTutorialKeyInfoWindow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionTutorialKeyInfoWindow", 0, Black.Sequence.Action.Menu.SequenceActionTutorialKeyInfoWindow.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionTutorialKeyInfoWindow", base.GetFieldProperties(), 1530086592, 277488219);
            
			
			
			return fieldProperties;
        }

		
    }
}