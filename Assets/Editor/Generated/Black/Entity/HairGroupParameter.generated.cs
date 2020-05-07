using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class HairGroupParameter : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string groupName1_;
		public string groupName2_;
		public string groupName3_;
		public string groupName4_;
		public UnityEngine.Vector4 width_;
		public UnityEngine.Vector4 shadowWidth_;
		public UnityEngine.Vector4 thinTipOffset_;
		public UnityEngine.Vector4 strandMultiplier_;
		public UnityEngine.Vector4 multiplicationRootOffset_;
		public UnityEngine.Vector4 multiplicationMiddleOffset_;
		public UnityEngine.Vector4 multiplicationTipOffset_;
		public UnityEngine.Vector4 vertsPerSegment_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HairGroupParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.HairGroupParameter", 0, Black.Entity.HairGroupParameter.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.Entity.HairGroupParameter", base.GetFieldProperties(), 766625306, -2137803352);
            
			
			
			return fieldProperties;
        }

		
    }
}