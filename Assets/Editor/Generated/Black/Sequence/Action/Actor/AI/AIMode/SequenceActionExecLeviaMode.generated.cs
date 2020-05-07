using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecLeviaMode : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aiSubModeIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveTpsQueryIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin attackTpsQueryIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin searchLabelIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin basePointIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin basePositionIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseRadiusIPin_;
		public uint aiSubModeId_;
		public uint moveTpsQueryId_;
		public uint attackTpsQueryId_;
		public uint searchLabelId_;
		public float baseRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecLeviaMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaMode", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaMode.ObjectType, null, properties, 0, 1904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaMode", base.GetFieldProperties(), 698308602, -936788191);
            
			fieldProperties.AddProperty(new Property("aiSubModeIdIPin_", 4197735112, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveTpsQueryIdIPin_", 3273480749, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackTpsQueryIdIPin_", 1198291866, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchLabelIdIPin_", 3150255779, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("basePointIPin_", 4079002129, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("basePositionIPin_", 1944077526, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseRadiusIPin_", 835056753, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aiSubModeId_", 4193448170, "SQEX.Ebony.Std.Fixid", 1840, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveTpsQueryId_", 3808585831, "SQEX.Ebony.Std.Fixid", 1844, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackTpsQueryId_", 1437473112, "SQEX.Ebony.Std.Fixid", 1848, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("searchLabelId_", 2732688593, "SQEX.Ebony.Std.Fixid", 1852, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseRadius_", 753445763, "float", 1856, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}