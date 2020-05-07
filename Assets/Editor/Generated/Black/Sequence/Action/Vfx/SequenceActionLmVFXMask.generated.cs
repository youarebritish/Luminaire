using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vfx
{
    public partial class SequenceActionLmVFXMask : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin mask_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unmask_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public bool radialBlur_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionLmVFXMask();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vfx.SequenceActionLmVFXMask", 0, Black.Sequence.Action.Vfx.SequenceActionLmVFXMask.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vfx.SequenceActionLmVFXMask", base.GetFieldProperties(), 1832608897, 1481652296);
            
			
			
			return fieldProperties;
        }

		
    }
}