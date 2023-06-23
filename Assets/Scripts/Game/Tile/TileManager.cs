using UnityEngine;
using MatchMatch.Common;

namespace MatchMatch.Game
{
    //===============================================================================================================================================
    //  전체 타일을 관리하는 타일 매니저 클래스
    //===============================================================================================================================================
    public class TileManager : MonoBehaviour
    {
        #region FIELD
        public Tile[] Tiles = new Tile[] { };           // 게임에서 사용되는 전체 타일 Array
        #endregion

        #region PUBLIC_METHOD
        //===========================================================================================================================================
        //
        //  게임에서 사용되는 전체 타일 Array를 갱신하고, 각 타일의 고유 ID를 정의함
        //
        //===========================================================================================================================================
        /// <summary>
        /// 게임에서 사용되는 전체 타일 Array를 갱신하고, 각 타일의 고유 ID를 정의하는 메서드.
        /// </summary>
        public void SetTileArray()
        {
            Tiles = transform.GetComponentsInChildren<Tile>();
            for(int id = 0 ; id < GameManager.CurrentLevelInfo.PlayableTileNum ; id ++)
            {
                Tiles[id].Id = id;
            }
        }

        //===========================================================================================================================================
        //
        //  현재 게임에서 사용되는 타일들 중, 비어있는 타일 개수 반환하는 메서드
        //
        //===========================================================================================================================================
        /// <summary>
        /// 현재 게임에서 사용되는 타일들 중, 비어있는 타일 개수 반환하는 메서드.
        /// </summary>
        /// <returns>비어있는 타일 개수</returns>
        public int GetEmptyTile()
        {
            int count = 0;                  // 반환 결과

            if(Tiles.Length == 0)           // 만약 리스트가 비어있으면, 최신화
            {
                SetTileArray();
            }

            //=======================================================================================================================================
            //  플레이 가능한 모든 타일에 대해 Loop
            //=======================================================================================================================================
            for ( int id = 0 ; id < GameManager.CurrentLevelInfo.PlayableTileNum ; id++ )
            {
                // 해당 타일이 비어있으면, Count 증가
                if (Tiles[id].CurrentBlock == null )
                {
                    count++;
                }
            }

            return count;
        }

        //===========================================================================================================================================
        //
        //  전체 타일에 대해 애니메이션을 초기화
        //
        //===========================================================================================================================================
        /// <summary>
        /// 전체 타일에 대해 애니메이션을 초기화하는 메서드.
        /// </summary>
        public void RefreshAllAnimation()
        {
            // 모든 타일들에 대해, Animation을 초기화
            for ( int i = 0 ; i < GameManager.CurrentLevelInfo.PlayableTileNum ; i++ )
            {
                if ( Tiles[i].CurrentBlock == null || Tiles[i].CurrentBlock.Type != BLOCK_TYPE.ON )
                {
                    Tiles[i].PlayResetAnimation();
                }
                else
                {
                    Tiles[i].PlayLightOnAnimation();
                }
            }
        }
        #endregion
    }
}