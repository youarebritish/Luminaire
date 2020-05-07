using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Calculate
{
    public partial class SequenceActionGetPointInTorus : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin find_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notFind_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin centerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin radiusPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin findPos_;
		public UnityEngine.Vector4 propCenter_;
		public float propRadius_;
		public float insidePercent_;
		public float outsidePercent_;
		public bool isRayCheck_;
		public float rayCheckUpperOffset_;
		public float rayCheckLowerOffset_;
		public bool isSphereCastUseOwnerRadius_;
		public float sphereCastRadius_;
		public int safetyCheckCountMax_;
		public string checkActorName_;
		public bool isEnableSpawnOnBG_;
		public bool isEnableSpawnOnProps_;
		public bool isEnableSpawnOnChara_;
		public bool isDebugDraw_;
		public float debugDrawTime_;
		public bool isDebugDrawRayCheck_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetPointInTorus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Calculate.SequenceActionGetPointInTorus", 0, Black.Sequence.Action.Level.Calculate.SequenceActionGetPointInTorus.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Calculate.SequenceActionGetPointInTorus", base.GetFieldProperties(), -1673037003, 187844336);
            
			
			
			return fieldProperties;
        }

		
    }
}