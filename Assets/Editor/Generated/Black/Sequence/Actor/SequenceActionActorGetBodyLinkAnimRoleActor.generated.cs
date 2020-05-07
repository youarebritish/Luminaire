using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorGetBodyLinkAnimRoleActor : Black.Sequence.Actor.SequenceVariableActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin roleActorOPin_;
		public uint linkAnimRoleId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetBodyLinkAnimRoleActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorGetBodyLinkAnimRoleActor", 0, Black.Sequence.Actor.SequenceActionActorGetBodyLinkAnimRoleActor.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorGetBodyLinkAnimRoleActor", base.GetFieldProperties(), -1176705911, -224066841);
            
			fieldProperties.AddProperty(new Property("roleActorOPin_", 2433503847, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkAnimRoleId_", 1761263946, "SQEX.Ebony.Std.Fixid", 320, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}