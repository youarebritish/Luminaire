using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Save
{
    public partial class SequenceActionLoad : Black.Sequence.Action.Save.SequenceActionSaveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin restartPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public int load_type_;
		public uint restartPointId_;
		public bool newgame_plus_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionLoad();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Save.SequenceActionLoad", 0, Black.Sequence.Action.Save.SequenceActionLoad.ObjectType, null, properties, 0, 792);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Save.SequenceActionLoad", base.GetFieldProperties(), -1149147810, 170040223);
            return fieldProperties;
        }

		
    }
}