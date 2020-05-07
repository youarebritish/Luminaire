using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDrawImage : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin indexInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin indexOutput_;
		public string filePath_;
		public int playSwfSpecificationType_;
		public UnityEngine.Vector4 dstPos_;
		public UnityEngine.Vector4 dstSize_;
		public UnityEngine.Vector4 srcPos_;
		public UnityEngine.Vector4 srcSize_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDrawImage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDrawImage", 0, Black.Sequence.Action.Debug.SequenceActionDrawImage.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDrawImage", base.GetFieldProperties(), -2062887445, -1162745555);
            
			
			
			return fieldProperties;
        }

		
    }
}