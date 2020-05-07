using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionEndCredit : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setVel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin checkReady_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ready_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notready_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin velPin_;
		public int type_;
		public string filePath_;
		public int dotsPerSec_;
		public float yScale_;
		public int ySpace_;
		public int xOffset_;
		public int nameStartOffset_;
		public int deleteOffset_;
		public int platform_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> nameList_;
		public bool isFontNoAdjust_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEndCredit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionEndCredit", 0, Black.Sequence.Action.Menu.SequenceActionEndCredit.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionEndCredit", base.GetFieldProperties(), -1764404343, -1128900719);
            
			
			
			return fieldProperties;
        }

		
    }
}