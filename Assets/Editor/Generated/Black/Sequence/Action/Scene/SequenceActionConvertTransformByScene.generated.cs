using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Scene
{
    public partial class SequenceActionConvertTransformByScene : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public int sceneID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneID_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outRotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionConvertTransformByScene();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Scene.SequenceActionConvertTransformByScene", 0, Black.Sequence.Action.Scene.SequenceActionConvertTransformByScene.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Scene.SequenceActionConvertTransformByScene", base.GetFieldProperties(), 2031193508, 1295570234);
            return fieldProperties;
        }

		
    }
}