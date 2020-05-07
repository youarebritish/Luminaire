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
            
			fieldProperties.AddProperty(new Property("color_", 3572781317, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensityEV_", 2764622858, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensity_", 1363281103, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("range_", 1969734135, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lpvEnabled_", 2490550915, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowOwner_", 2134974485, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowIgnoreActor_", 3475751801, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}