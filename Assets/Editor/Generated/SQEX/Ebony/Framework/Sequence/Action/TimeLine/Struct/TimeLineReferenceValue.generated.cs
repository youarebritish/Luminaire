using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct
{
    public partial class TimeLineReferenceValue : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine dependencyProperty_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TimeLineReferenceValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue", 0, SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue", base.GetFieldProperties(), 1718095360, 1670567748);
            
			
			
			fieldProperties.AddProperty(new Property("dependencyProperty_", 1510119278, "SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine", 8, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}