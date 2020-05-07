using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu.Impl.MultiPlayer
{
    public partial class MultiPlayerChocoboBattleMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerChocoboBattleMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerChocoboBattleMenuEntity", 0, Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerChocoboBattleMenuEntity.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerChocoboBattleMenuEntity", base.GetFieldProperties(), -659527662, 203519969);
            return fieldProperties;
        }

		
    }
}