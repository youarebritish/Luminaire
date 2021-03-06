//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Save.TimedQuest
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveTimedQuestPointStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint scheduleId;
		public long acquisition;
		public long consumption;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveTimedQuestPointStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.TimedQuest.SaveTimedQuestPointStruct", 0, Black.Save.TimedQuest.SaveTimedQuestPointStruct.ObjectType, null, properties, 0, 24);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.TimedQuest.SaveTimedQuestPointStruct", null, 2068533484, -1811781727);
            
			
			
			fieldProperties.AddProperty(new Property("scheduleId", 2178565857, "SQEX.Luminous.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("acquisition", 583627844, "int64_t", 8, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("consumption", 722593332, "int64_t", 16, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}