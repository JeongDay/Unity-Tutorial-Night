using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Grid grid;
    
    public Color gridColor = Color.white;
    public float gridSize = 1f;
    public int gridWidth = 13;
    public int gridHeight = 10;

    public Material gridMaterial;

    public GameObject towerPrefab;
    public Transform indicator;

    private Camera mainCam;
    private Vector3 lastPos;
    
    private List<Vector3Int> towerPosList = new List<Vector3Int>();
    
    void Start()
    {
        mainCam = Camera.main;

        DrawGrid();
    }

    void Update()
    {
        Vector3 selectedPos = GetSelectedMapPosition();
        Vector3Int cellPos = grid.WorldToCell(selectedPos);
        indicator.position = grid.GetCellCenterWorld(cellPos);

        if (Input.GetMouseButtonDown(0))
        {
            if (!towerPosList.Contains(cellPos))
            {
                Instantiate(towerPrefab, grid.GetCellCenterWorld(cellPos), Quaternion.identity);
                towerPosList.Add(cellPos);
            }
        }
    }

    public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mainCam.nearClipPlane;

        Ray ray = mainCam.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                lastPos = hit.point;
                indicator.gameObject.SetActive(true);
            }
            else if (hit.collider.CompareTag("Way"))
            {
                indicator.gameObject.SetActive(false);
            }
        }

        return lastPos;
    }
    
    private void DrawGrid()
    {
        for (int z = 0; z <= gridHeight; z++)
        {
            GameObject lineGO = new GameObject($"LineRenderer_Z");
            
            lineGO.transform.SetParent(transform);
            LineRenderer lr = lineGO.AddComponent<LineRenderer>();

            lr.startColor = gridColor;
            lr.endColor = gridColor;
            lr.startWidth = 0.05f;
            lr.endWidth = 0.05f;
            
            if (gridMaterial != null)
                lr.material = gridMaterial;

            lr.positionCount = 2;
            lr.SetPosition(0, new Vector3(0, 0, z * gridSize));
            lr.SetPosition(1, new Vector3(gridWidth * gridSize, 0, z * gridSize));
        }

        for (int x = 0; x <= gridWidth; x++)
        {
            GameObject lineGO = new GameObject($"LineRenderer_X");
            lineGO.transform.SetParent(transform);
            LineRenderer lr = lineGO.AddComponent<LineRenderer>();

            lr.startColor = gridColor;
            lr.endColor = gridColor;
            lr.startWidth = 0.05f;
            lr.endWidth = 0.05f;
            
            if (gridMaterial != null)
                lr.material = gridMaterial;

            lr.positionCount = 2;
            lr.SetPosition(0, new Vector3(x * gridSize, 0, 0));
            lr.SetPosition(1, new Vector3(x * gridSize, 0, gridHeight * gridSize));
        }
    }
}