using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu.Impl.MultiPlayer
{
    public partial class MultiPlayerChocoboTrainingMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerChocoboTrainingMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerChocoboTrainingMenuEntity", 0, Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerChocoboTrainingMenuEntity.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerChocoboTrainingMenuEntity", base.GetFieldProperties(), 1637933928, 1378813660);
            
			
			
			return fieldProperties;
        }

		
    }
}