using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetPrefabLoad : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin prefabPathPin_;
		public string prefabPath_;
		public bool isRelese_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scalePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorPrefabPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetPrefabLoad();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetPrefabLoad", 0, Black.Sequence.Action.Level.SequenceActionSetPrefabLoad.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetPrefabLoad", base.GetFieldProperties(), 2093342352, -1628759324);
            return fieldProperties;
        }

		
    }
}