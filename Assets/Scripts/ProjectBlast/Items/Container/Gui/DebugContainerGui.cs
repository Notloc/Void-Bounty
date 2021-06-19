using ProjectBlast.Items.Containers;
using ProjectBlast.Items.Containers.Gui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectBlast.Debugging
{
    public class DebugContainerGui : MonoBehaviour
    {
        Container container;
        [SerializeField] ContainerGui containerView = null;
        [SerializeField] List<ItemBase> items = null;
        [SerializeField] int width = 3, height = 3;

        private void Start()
        {
            container = ScriptableObject.CreateInstance<Container>();
            container.Initialize(width, height);
            
            foreach (ItemBase item in items)
            {
                if (item as WeaponBase)
                {
                    container.AddItem(new WeaponInstance(item as WeaponBase));
                }
                else if (item as WeaponAttachmentBase)
                {
                    container.AddItem(new WeaponAttachmentInstance(item as WeaponAttachmentBase));
                }
                else
                {
                    container.AddItem(new ItemInstance(item));
                }
            }

            containerView.SetContainer(container);
        }
    }
}