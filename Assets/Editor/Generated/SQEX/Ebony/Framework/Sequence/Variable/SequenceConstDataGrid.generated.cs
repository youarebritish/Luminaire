using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstDataGrid : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rowIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rowValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cellValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin colNumPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rowNumPin_;
		public string gridName_;
		public int windowWidth_;
		public int windowHeight_;
		public int columnNum_;
		public int keyIndex_;
		public int accessRowIndex_;
		public int accessColIndex_;
		public string name1_;
		public int type1_;
		public int width1_;
		public string name2_;
		public int type2_;
		public int width2_;
		public string name3_;
		public int type3_;
		public int width3_;
		public string name4_;
		public int type4_;
		public int width4_;
		public string name5_;
		public int type5_;
		public int width5_;
		public string name6_;
		public int type6_;
		public int width6_;
		public string name7_;
		public int type7_;
		public int width7_;
		public string name8_;
		public int type8_;
		public int width8_;
		public SQEX.Ebony.Framework.Data.DataTable dataTable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstDataGrid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ObjectType, null, properties, 0, 872);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid", base.GetFieldProperties(), -553805739, 1052445092);
            
			fieldProperties.AddProperty(new Property("colIndexPin_", 2959595203, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 88, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rowIndexPin_", 3906869421, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rowValuePin_", 2978124632, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cellValuePin_", 3433918938, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colNumPin_", 922488491, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rowNumPin_", 2747571493, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("gridName_", 3154002799, "Ebony.Base.String", 616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("windowWidth_", 1689981896, "int", 632, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("windowHeight_", 4042671631, "int", 636, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("columnNum_", 3716724542, "int", 640, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("keyIndex_", 736206677, "int", 644, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("accessRowIndex_", 2834159080, "int", 648, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("accessColIndex_", 3999911658, "int", 652, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name1_", 2345983262, "Ebony.Base.String", 656, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type1_", 3564075633, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 672, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width1_", 1516882287, "int", 676, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name2_", 2345541977, "Ebony.Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type2_", 3564516918, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 696, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width2_", 442967576, "int", 700, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name3_", 1271921456, "Ebony.Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type3_", 2490602207, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 720, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width3_", 442820481, "int", 724, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name4_", 1271480171, "Ebony.Base.String", 728, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type4_", 3563531180, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 744, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width4_", 1516441002, "int", 748, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name5_", 2345394882, "Ebony.Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type5_", 3563384085, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 768, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width5_", 442526291, "int", 772, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name6_", 2344850429, "Ebony.Base.String", 776, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type6_", 3563928538, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 792, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width6_", 442379196, "int", 796, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name7_", 1271333076, "Ebony.Base.String", 800, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type7_", 2490013827, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 816, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width7_", 1515896549, "int", 820, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("name8_", 2347116095, "Ebony.Base.String", 824, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("type8_", 3562942800, "SQEX.Ebony.Framework.Sequence.Variable.SequenceConstDataGrid.ColumnType", 840, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("width8_", 1515749454, "int", 844, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("dataTable_", 3650498624, "SQEX.Ebony.Framework.Data.DataTable", 848, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}