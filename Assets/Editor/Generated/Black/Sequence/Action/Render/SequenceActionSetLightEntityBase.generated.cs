using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetLightEntityBase : Black.Sequence.Actor.SequenceActionEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin color_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intensityEV_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin radius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin range_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lpvEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shadowOwner_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shadowIgnoreActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLightEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetLightEntityBase", 0, Black.Sequence.Action.Render.SequenceActionSetLightEntityBase.ObjectType, null, properties, 0, 1160);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetLightEntityBase", base.GetFieldProperties(), 1105875588, 1742242556);
            
			
			
			return fieldProperties;
        }

		
    }
}