using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorAttach : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin self_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin base_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bonePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin elementPin_;
		public uint joint_;
		public uint elementId_;
		public float interpolateTime_;
		public bool ignoreParentRotationFlag_;
		public bool localRotationFlag_;
		public bool offsetRotationFixFlag_;
		public bool releaseOnDetach_;
		public bool useParentScale_;
		public bool updateWhilePause_;
		public bool linkageBodyMessage_;
		public bool isCalcYOffset_;
		public uint yOffsetOriginId_;
		public UnityEngine.Vector4 offsetPosition_;
		public UnityEngine.Vector4 offsetRotation_;
		public bool isSkipPhysicsReset_;
		public int customAttach_;
		public bool isHide_;
		public bool isUseProxyWhileAttaching_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAttach();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorAttach", 0, Black.Sequence.Actor.SequenceActionActorAttach.ObjectType, null, properties, 0, 976);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorAttach", base.GetFieldProperties(), 1544468271, -904668818);
            return fieldProperties;
        }

		
    }
}