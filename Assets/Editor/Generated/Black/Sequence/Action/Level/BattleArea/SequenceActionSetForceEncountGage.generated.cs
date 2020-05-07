using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.BattleArea
{
    public partial class SequenceActionSetForceEncountGage : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin gage_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float encountGage_;
		public float second_;
		public string bgmFilePath_;
		public bool resultReset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetForceEncountGage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.BattleArea.SequenceActionSetForceEncountGage", 0, Black.Sequence.Action.Level.BattleArea.SequenceActionSetForceEncountGage.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.BattleArea.SequenceActionSetForceEncountGage", base.GetFieldProperties(), -840380343, 624898347);
            
			
			
			return fieldProperties;
        }

		
    }
}