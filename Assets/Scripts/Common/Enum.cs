namespace MatchMatch.Common
{
    #region PUBLIC_ENUM
    //===============================================================================================================================================
    //
    //  MatchMatch에서 사용하고있는 6가지 방향
    //
    //===============================================================================================================================================
    public enum DIRECTION
    {
        UP          = 0,
        RIGHT_UP    = 1,
        RIGHT_DOWN  = 2,
        DOWN        = 3,
        LEFT_DOWN   = 4,
        LEFT_UP     = 5,
        LENGTH      = 6,
        NOT_DEFINED = -1
    }

    //===============================================================================================================================================
    //
    //  게임에서 사용하는 블럭의 타입
    //
    //===============================================================================================================================================
    public enum BLOCK_TYPE
    {
        BLUE        = 0, 
        GREEN       = 1, 
        ORANGE      = 2, 
        PURPLE      = 3, 
        RED         = 4, 
        YELLOW      = 5, 
        ON          = 6, 
        OFF         = 7,
        SUPER_0     = 8,
        SUPER_1     = 9,
        SUPER_2     = 10,
        BOMB        = 11,
        ROCK        = 12,
        LEN         = 13,
    };

    //===============================================================================================================================================
    //
    //  매칭 결과, 블럭을 터트릴지 말지 결정하는 기준값
    //
    //===============================================================================================================================================
    public enum MATCH_THRESHOLD
    {
        LINE_MATCH  = 3,
        GROUP_MATCH = 4
    };

    //===============================================================================================================================================
    //
    //  사운드 플레이를 위한 효과음 목록
    //
    //===============================================================================================================================================
    public enum SFX
    {
        POP,
        CREATE,
        CANT,
        DONT_MOVE,
        TADA,
        STAR,
        READY_GO,
        CLICK
    }

    //===============================================================================================================================================
    //
    //  사운드 플레이를 위한 음악 목록
    //
    //===============================================================================================================================================
    public enum BGM
    {
        GAME,
        LOBBY
    }
    #endregion
}

