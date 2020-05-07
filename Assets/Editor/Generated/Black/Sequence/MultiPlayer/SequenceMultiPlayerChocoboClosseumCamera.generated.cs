using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerChocoboClosseumCamera : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin end_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocoboList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enemyList_;
		public UnityEngine.Vector4 centerPosition;
		public float stadiumRadius;
		public UnityEngine.Vector4 battleCameraPositionBase;
		public float battleCameraBaseRadius;
		public UnityEngine.Vector4 battleCameraFirstPos;
		public float battleCameraVelocity;
		public float battleCameraMaxDistRate;
		public float battleCameraMinDistRate;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerChocoboClosseumCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerChocoboClosseumCamera", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerChocoboClosseumCamera.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerChocoboClosseumCamera", base.GetFieldProperties(), -548013418, 360447602);
            
			
			
			return fieldProperties;
        }

		
    }
}