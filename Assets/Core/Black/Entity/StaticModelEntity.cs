﻿//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using System.IO;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;
using UnityEngine;
using CsSystem = System;


namespace Black.Entity
{
	public partial class StaticModelEntity : Black.Entity.TransformEntity
	{
        public override void SetupGameObject(GameObject gameObject)
        {
            base.SetupGameObject(gameObject);


            Debug.Log(CsSystem.IO.Path.ChangeExtension(this.sourcePath_ + ".fbx", null));
            var meshObj = Resources.Load(CsSystem.IO.Path.ChangeExtension(this.sourcePath_ + ".fbx", null), typeof(GameObject)) as GameObject;
            var meshInstance = UnityEngine.Object.Instantiate(meshObj, gameObject.transform) as GameObject;

            gameObject.AddComponent<MeshRenderer>();
 
        }
    }
}