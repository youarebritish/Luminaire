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
            
			fieldProperties.AddProperty(new Property("initializePin_", 2775375367, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movePrevPin_", 3867206685, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveNextPin_", 2979458537, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movePrevStopPin_", 3801240765, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveNextStopPin_", 3898943609, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movePrevPagePin_", 2648482162, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveNextPagePin_", 2778163422, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movePrevPageStopPin_", 1525458266, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveNextPageStopPin_", 1560380262, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialIndexPin_", 2129047013, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialScrollPin_", 2883911738, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("itemsNumPin_", 944522089, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableListPin_", 2803560794, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("deltaPin_", 3105682045, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1480, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initializeOutPin_", 3101645657, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1576, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueChangedPin_", 3891576526, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1672, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueUnchangedPin_", 1795146851, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1768, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectedIndexPin_", 1123068256, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialIndex_", 410109010, "int", 1952, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("itemsNum_", 1329119606, "int", 1956, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("delta_", 4049009242, "int", 1960, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("loop_", 2477697500, "bool", 1964, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("minimum_", 3695808120, "int", 1968, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("slotNumPin_", 2761805739, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("scrollPin_", 2826020252, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("indexMinusScrollPin_", 3695946736, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canScrollUpPin_", 4275207661, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canScrollDownPin_", 844447864, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableScroll_", 1514060080, "bool", 2416, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("slotNum_", 636238944, "int", 2420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("soundIdSelect_", 756718202, "SQEX.Ebony.Std.Fixid", 2424, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}