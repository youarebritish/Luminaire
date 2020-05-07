using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionDialogOpenBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public uint nameFixId_;
		public uint dialogFixId_;
		public string nameString_;
		public string dialogString_;
		public bool nameEdge_;
		public bool dialogEdge_;
		public UnityEngine.Vector4 dialogPos_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin windowID_;
		public float dialogSeconds_;
		public int messageSpecificationType_;
		public bool forceDisp_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDialogOpenBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionDialogOpenBase", 0, Black.Sequence.Action.Menu.SequenceActionDialogOpenBase.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionDialogOpenBase", base.GetFieldProperties(), -1320804958, -849110805);
            
			
			
			return fieldProperties;
        }

		
    }
}