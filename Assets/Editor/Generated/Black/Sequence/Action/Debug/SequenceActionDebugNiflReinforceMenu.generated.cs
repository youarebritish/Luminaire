using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugNiflReinforceMenu : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin end_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqNext_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqPreview_;
		public bool isPlayerControlOff_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedSelecting_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin selectedTeamId;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugNiflReinforceMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugNiflReinforceMenu", 0, Black.Sequence.Action.Debug.SequenceActionDebugNiflReinforceMenu.ObjectType, null, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugNiflReinforceMenu", base.GetFieldProperties(), -2018013322, -327631234);
            
			
			
			return fieldProperties;
        }

		
    }
}