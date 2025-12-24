using UnityEngine;

namespace PLAYERTWO.ARPGProject
{
    [AddComponentMenu("PLAYER TWO/ARPG Project/Quest/Quest Marker Manager")]
    public class QuestMarkerManager : Singleton<QuestMarkerManager>
    {
        [Header("World Markers")]
        [Tooltip(
            "The Game Object that represents the marker when a Quest Giver has a Quest available."
        )]
        public GameObject availableQuestMarker;

        [Tooltip(
            "The Game Object that represents the marker when a Quest Giver has a Quest in progress."
        )]
        public GameObject inProgressQuestMarker;

        [Header("Minimap Markers")]
        public Sprite availableQuestSprite;
        public Sprite inProgressQuestSprite;

        public virtual void InstantiateMarkers(
            Transform target,
            Vector3 worldOffset,
            ref GameObject availableMarker,
            ref GameObject inProgressMarker,
            ref GameObject availableIcon,
            ref GameObject inProgressIcon
        )
        {
            InstantiateObject(target, worldOffset, ref availableMarker, availableQuestMarker);
            InstantiateObject(target, worldOffset, ref inProgressMarker, inProgressQuestMarker);
            InstantiateMinimapIcon(target, ref availableIcon, availableQuestSprite);
            InstantiateMinimapIcon(target, ref inProgressIcon, inProgressQuestSprite);
        }

        public virtual void InstantiateMinimapIcon(
            Transform target,
            ref GameObject instance,
            Sprite sprite
        )
        {
            if (instance || !sprite)
                return;

            instance = new GameObject("Minimap Icon");
            instance.AddComponent<MinimapIcon>().UpdateSprite(sprite);
            instance.transform.SetParent(target, false);
            instance.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        }

        protected virtual void InstantiateObject(
            Transform target,
            Vector3 worldOffset,
            ref GameObject instance,
            Object go
        )
        {
            if (instance || !go)
                return;

            instance = (GameObject)Instantiate(go, Vector3.zero, Quaternion.identity);
            instance.transform.SetParent(target, false);
            instance.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
            instance.transform.localPosition += worldOffset;
        }
    }
}
