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

namespace Black.AIGraph.Extend.Invoke.Monster
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class AIGraphInvokeSetGambitFinTime : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetGambitFinTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetGambitFinTime", 0, Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetGambitFinTime.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Monster.AIGraphInvokeSetGambitFinTime", base.GetFieldProperties(), -969668923, -619984883);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphInvokeSetGambitFinTime();
        }
		
    }
}