using System.Collections;
using Wrld;
using Wrld.Space;
using UnityEngine;

public class BuildingAltitudePicking : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab = null;
    private float x, y;
    public int numberOfEnemies;
    private LatLong cameraLocation = LatLong.FromDegrees(37.795641, -122.404173);
    private LatLong enemylocation;


    private void OnEnable()
    {
        StartCoroutine(PlaceEnemies());
    }
    IEnumerator PlaceEnemies()
    {
        Api.Instance.CameraApi.MoveTo(cameraLocation, distanceFromInterest: 400, headingDegrees: 0, tiltDegrees: 45);
        yield return new WaitForSeconds(4.0f);
        for (int i=0;i <= numberOfEnemies;i++)
        {
            x =Random.Range(37.78f, 37.80f);
            y =Random.Range(-122.40f, -122.41f);
            enemylocation = LatLong.FromDegrees(x, y);
            MakeBox(enemylocation);
        }
        
    }

    void MakeBox(LatLong latLong)
    {
        var ray = Api.Instance.SpacesApi.LatLongToVerticallyDownRay(latLong);
        LatLongAltitude buildingIntersectionPoint;
        var didIntersectBuilding = Api.Instance.BuildingsApi.TryFindIntersectionWithBuilding(ray, out buildingIntersectionPoint);
        if (didIntersectBuilding)
        {
            var boxAnchor = Instantiate(boxPrefab) as GameObject;
            boxAnchor.GetComponent<GeographicTransform>().SetPosition(buildingIntersectionPoint.GetLatLong());

            var box = boxAnchor.transform.GetChild(0);
            box.localPosition = Vector3.up * (float)buildingIntersectionPoint.GetAltitude();
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
