using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer
{
    public partial class TPSQueryCommunicator : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TPSQueryCommunicator();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.TPSQueryCommunicator", 0, Black.MultiPlayer.TPSQueryCommunicator.ObjectType, null, properties, 5, 11312);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.TPSQueryCommunicator", base.GetFieldProperties(), 1118640307, -386692731);
            return fieldProperties;
        }

		
    }
}