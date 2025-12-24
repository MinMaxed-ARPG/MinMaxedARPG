using UnityEngine;

namespace PLAYERTWO.ARPGProject
{
    [System.Serializable]
    public class EquipmentsSerializer
    {
        public ItemSerializer rightHand;
        public ItemSerializer leftHand;
        public ItemSerializer helm;
        public ItemSerializer chest;
        public ItemSerializer pants;
        public ItemSerializer gloves;
        public ItemSerializer boots;
        public ItemSerializer[] consumables;
        public ItemSerializer shoulder;
        public ItemSerializer neck;
        public ItemSerializer back;
        public ItemSerializer belt;
        public ItemSerializer ringleft;
        public ItemSerializer ringright;

        public EquipmentsSerializer(CharacterEquipments equipments)
        {
            SerializeItem(equipments.currentRightHand, ref rightHand);
            SerializeItem(equipments.currentLeftHand, ref leftHand);
            SerializeItem(equipments.currentHelm, ref helm);
            SerializeItem(equipments.currentChest, ref chest);
            SerializeItem(equipments.currentPants, ref pants);
            SerializeItem(equipments.currentGloves, ref gloves);
            SerializeItem(equipments.currentBoots, ref boots);
            SerializeConsumables(equipments.currentConsumables);
            SerializeItem(equipments.currentBoots, ref shoulder);
            SerializeItem(equipments.currentBoots, ref neck);
            SerializeItem(equipments.currentBoots, ref back);
            SerializeItem(equipments.currentBoots, ref belt);
            SerializeItem(equipments.currentBoots, ref ringleft);
            SerializeItem(equipments.currentBoots, ref ringright);
        }

        protected virtual void SerializeItem(ItemInstance instance, ref ItemSerializer item)
        {
            if (instance != null)
                item = new ItemSerializer(instance);
        }

        protected virtual void SerializeConsumables(ItemInstance[] consumables)
        {
            this.consumables = new ItemSerializer[consumables.Length];

            for (int i = 0; i < this.consumables.Length; i++)
            {
                if (consumables[i] == null) continue;

                this.consumables[i] = new ItemSerializer(consumables[i]);
            }
        }

        public virtual string ToJson() => JsonUtility.ToJson(this);

        public static EquipmentsSerializer FromJson(string json) =>
            JsonUtility.FromJson<EquipmentsSerializer>(json);
    }
}
