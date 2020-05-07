using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer
{
    public partial class BattleSync : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BattleSync();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.BattleSync", 0, Black.MultiPlayer.BattleSync.ObjectType, null, properties, 2, 160);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.BattleSync", base.GetFieldProperties(), 1403569589, 1998389357);
            return fieldProperties;
        }

		
    }
}