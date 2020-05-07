using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.Recognition
{
    public partial class SequenceActionAICheckVisibilityFromAllEnemies : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outStartPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outStopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changedVisiblePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changedInvisiblePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin visibilityPin_;
		public float changeInterval_;
		public float changeIntervalVisible_;
		public float changeCooldownInvisible_;
		public float changeCooldownVisible_;
		public bool isEnableFirstSignal_;
		public float forceVisibleDistance_;
		public float invisibleHight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAICheckVisibilityFromAllEnemies();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.Recognition.SequenceActionAICheckVisibilityFromAllEnemies", 0, Black.Sequence.Action.Actor.AI.Recognition.SequenceActionAICheckVisibilityFromAllEnemies.ObjectType, null, properties, 0, 1056);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.Recognition.SequenceActionAICheckVisibilityFromAllEnemies", base.GetFieldProperties(), 422856061, -194041053);
            
			
			
			return fieldProperties;
        }

		
    }
}