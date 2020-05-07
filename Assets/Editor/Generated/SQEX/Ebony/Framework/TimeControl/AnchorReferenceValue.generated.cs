using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl
{
    public partial class AnchorReferenceValue : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int valueType_;
		public object dependencyProperty_;
		public bool dependencyPropertyEnable_;
		public int elementIndex_;
		public bool curveEnable_;
		public float maxValue_;
		public float minValue_;
		public IList<SQEX.Ebony.Framework.TimeControl.AnchorPoint> anchorPoints_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AnchorReferenceValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.AnchorReferenceValue", 0, SQEX.Ebony.Framework.TimeControl.AnchorReferenceValue.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.AnchorReferenceValue", base.GetFieldProperties(), 1694444979, 411824244);
            
			
			
			return fieldProperties;
        }

		
    }
}