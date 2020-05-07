using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.SpecialAnim.CordAnim
{
    public partial class CordAnimationComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> boneNames_;
		public float spring_;
		public float damping_;
		public float parentAngularDamping_;
		public float childAngularDamping_;
		public bool headRoot_;
		public bool twosideRoot_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CordAnimationComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.SpecialAnim.CordAnim.CordAnimationComponentData", 0, Black.Actor.Component.SpecialAnim.CordAnim.CordAnimationComponentData.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.SpecialAnim.CordAnim.CordAnimationComponentData", base.GetFieldProperties(), 1394393593, 1203659094);
            return fieldProperties;
        }

		
    }
}