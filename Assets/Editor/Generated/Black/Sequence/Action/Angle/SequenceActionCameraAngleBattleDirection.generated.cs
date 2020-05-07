using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleBattleDirection : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin targetCacheOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultVOutputPin_;
		public int angleOperatorType_;
		public bool isUseCache_;
		public bool isUseTargetCache_;
		public bool isBlockActivateOutWhenPcTargetIsNotExist_;
		public float baseYHeightFromTrans_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleBattleDirection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection.ObjectType, null, properties, 0, 1896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection", base.GetFieldProperties(), 1089011804, -1031551262);
            return fieldProperties;
        }

		
    }
}