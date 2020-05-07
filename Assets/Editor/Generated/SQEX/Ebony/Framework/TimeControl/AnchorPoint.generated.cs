using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl
{
    public partial class AnchorPoint : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float time_;
		public float value_;
		public float ySplit_;
		public UnityEngine.Vector4 control0_;
		public UnityEngine.Vector4 control1_;
		public int leftCurveType_;
		public int curveType_;
		public bool isSplitted_;
		public bool isSplittedControlPoint_;
		public bool hasExpandableHandles_;
		public bool hasBalanceHandles_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AnchorPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.AnchorPoint", 0, SQEX.Ebony.Framework.TimeControl.AnchorPoint.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.AnchorPoint", base.GetFieldProperties(), 1092863664, 891530735);
            
			
			
			return fieldProperties;
        }

		
    }
}