using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectMenuOperation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin initializePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin movePrevPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin moveNextPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin movePrevStopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin moveNextStopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin movePrevPagePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin moveNextPagePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin movePrevPageStopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin moveNextPageStopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin initialIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin initialScrollPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin itemsNumPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin deltaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin initializeOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin valueChangedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin valueUnchangedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin selectedIndexPin_;
		public int initialIndex_;
		public int itemsNum_;
		public int delta_;
		public bool loop_;
		public int minimum_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slotNumPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin scrollPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin indexMinusScrollPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin canScrollUpPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin canScrollDownPin_;
		public bool enableScroll_;
		public int slotNum_;
		public uint soundIdSelect_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectMenuOperation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectMenuOperation", 0, Black.Sequence.Action.Menu.SequenceActionSelectMenuOperation.ObjectType, null, properties, 0, 2440);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectMenuOperation", base.GetFieldProperties(), -1809723304, -1543994973);
            
			
			
			return fieldProperties;
        }

		
    }
}