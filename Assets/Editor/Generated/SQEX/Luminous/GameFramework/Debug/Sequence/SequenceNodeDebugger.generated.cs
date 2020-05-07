using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.GameFramework.Debug.Sequence
{
    public partial class SequenceNodeDebugger
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceNodeDebugger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.GameFramework.Debug.Sequence.SequenceNodeDebugger", 0, SQEX.Luminous.GameFramework.Debug.Sequence.SequenceNodeDebugger.ObjectType, null, properties, 17, 336);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("SQEX.Luminous.GameFramework.Debug.Sequence.SequenceNodeDebugger", null, -1884911257, 1018576002);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}