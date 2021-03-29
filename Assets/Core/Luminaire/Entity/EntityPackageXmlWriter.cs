using Black.Entity;
using Luminous;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

namespace Luminaire.Entity
{
    /// <summary>
    /// Exports an entity package to a plaintext XML format.
    /// </summary>
    public class EntityPackageXmlWriter
    {
        public void Export(SQEX.Ebony.Framework.Entity.EntityPackage package, string outputPath)
        {
            Debug.Assert(package != null);

            var rootElement = MakeRootElement(package);
            rootElement.Add(MakeObjectsElement());

            var xDocument = new XDocument(rootElement);

            var writerSettings = new XmlWriterSettings
            {
                OmitXmlDeclaration = false,
                Indent = true
            };

            using (var writer = XmlWriter.Create(outputPath, writerSettings))
            {
                xDocument.Save(writer);
            }
        }

        private static IEnumerable<XElement> MakeObjectElements(SQEX.Ebony.Framework.Entity.EntityPackage package)
        {
            // TODO use package.entities_; note the ownership structure
            // Need to do this recursively to get all objects
            // Seem to need to worry about IntrusivePointerDynamicArray, PointerArray, and maybe Pointer?

            //from obj in package.loadedObjects_
            //select MakeObjectElement(obj);
            return null;
        }

        /*private static IEnumerable<XElement> MakeChildObjectElements(Luminous.Core.Object.Object obj)
        {

        }*/

        private static XElement MakeObjectElement(SQEX.Luminous.Core.Object.Object obj, ObjectInfo objInfo, OwnerInfo? ownerInfo)
        {
            var result = new XElement("object");
            result.SetAttributeValue("objectIndex", objInfo.ObjectIndex);
            result.SetAttributeValue("checked", objInfo.Checked);
            //result.SetAttributeValue("type", obj.GetObjectType().Name); //error CS0122: 'ObjectType.Name' is inaccessible due to its protection level
            result.SetAttributeValue("path", objInfo.Path);
            result.SetAttributeValue("name", objInfo.Name);

            if (ownerInfo.HasValue)
            {
                result.SetAttributeValue("ownerPath", ownerInfo.Value.OwnerPath);
                result.SetAttributeValue("ownerIndex", ownerInfo.Value.OwnerIndex);
                result.SetAttributeValue("owner", ownerInfo.Value.OwnerName);
            }

            return result;
        }

        private static XElement MakeObjectsElement()
        {
            return new XElement("objects");
        }

        private static XElement MakeRootElement(SQEX.Ebony.Framework.Entity.EntityPackage package)
        {
            var result = new XElement("package");
            result.SetAttributeValue("name", package.simpleName_);

            return result;
        }
        private struct ObjectInfo
        {
            public ObjectInfo(bool @checked, string name, int objectIndex, string path)
            {
                Checked = @checked;
                Name = name ?? throw new ArgumentNullException(nameof(name));
                ObjectIndex = objectIndex;
                Path = path ?? throw new ArgumentNullException(nameof(path));
            }

            public bool Checked { get; }
            public string Name { get; }
            public int ObjectIndex { get; }
            public string Path { get; }
        }

        private struct OwnerInfo
        {
            public OwnerInfo(int ownerIndex, string ownerName, string ownerPath)
            {
                OwnerIndex = ownerIndex;
                OwnerName = ownerName ?? throw new ArgumentNullException(nameof(ownerName));
                OwnerPath = ownerPath ?? throw new ArgumentNullException(nameof(ownerPath));
            }

            public int OwnerIndex { get; }
            public string OwnerName { get; }
            public string OwnerPath { get; }
        }
    }
}