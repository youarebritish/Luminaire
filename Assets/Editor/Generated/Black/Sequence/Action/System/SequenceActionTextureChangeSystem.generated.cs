using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionTextureChangeSystem : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inLoop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPrev_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inNext_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outLoaded_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inInterval_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCurrentFolder_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outLoadedPattern_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outLoadedTextureIndex_;
		public string materialName_;
		public string textureName_;
		public float interval_;
		public int currentFolder_;
		public IList<SQEX.Ebony.Framework.Utility.IntArrayItem> maxList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTextureChangeSystem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionTextureChangeSystem", 0, Black.Sequence.Action.System.SequenceActionTextureChangeSystem.ObjectType, null, properties, 0, 1584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionTextureChangeSystem", base.GetFieldProperties(), -1907151139, -477534070);
            
			
			
			return fieldProperties;
        }

		
    }
}