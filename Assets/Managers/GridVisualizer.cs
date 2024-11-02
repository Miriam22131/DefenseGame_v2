using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridVisualizer : MonoBehaviour
{
     [SerializeField] private LayerMask GroundMask;

    // Start is called before the first frame update
    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        int w = 3;
        int h = 3;
        int size = 20;
        float halfSize = size / 2f;

        float posX = 0 - ((w * size) + halfSize);
        for (int i = -w; i <= w + 1; i++)
        {
            float posZ = 0 - ((h * size) + halfSize);
            for (int j = -h; j <= h + 1; j++)
            {
                posZ += size;

                Gizmos.DrawWireCube((new Vector3(posX, 0, posZ)), Vector3.one * size);

                //Debug.Log($"{posX},{posZ}");
            }
            posX += size;
        }

        Gizmos.color = Color.yellow;

        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo, 20000, GroundMask))
        {
            //var pos = GameManager.GameGrid.GetCellWorldCenter(hitInfo.point);

            //Gizmos.DrawWireCube(pos, Vector3.one * GameManager.GameGrid.CellSize);
        }
    }
    
}
