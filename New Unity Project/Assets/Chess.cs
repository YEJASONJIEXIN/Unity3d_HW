using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour
{

    private int turn = 1;
    private int[,] grid = new int[3, 3];

    // 重新开始游戏
    void Start()
    {
        Restart();
    }

    void Restart()
    {
        turn = 1;
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                grid[i, j] = 0;
            }
        }
    }

    void OnGUI()
    {
        //设置button中字体的大小
        GUI.skin.button.fontSize = 20;

        //设置label中字体大小和颜色
        GUIStyle style = new GUIStyle();
        style.fontSize = 40;
        style.normal.textColor = new Color(255, 255, 255);

        //判断是否点击Restart按钮
        if (GUI.Button(new Rect(360, 500, 80, 80), "Restart"))
        {
            Restart();
        }

        //判断游戏是否结束
        int result = judge();
        if (result == 1)
        {
            GUI.Label(new Rect(340, 170, 100, 50), "O wins!", style);
        }
        else if (result == 2)
        {
            GUI.Label(new Rect(340, 170, 100, 50), "X wins!", style);
        }
        else if (result == 3)
        {
            GUI.Label(new Rect(300, 170, 100, 50), "GameOver!", style);
        }

        //生成棋盘并判断格子是否被点击
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[i, j] == 1)
                {
                    GUI.Button(new Rect(280 + i * 80, 220 + j * 80, 80, 80), "O");
                }
                else if (grid[i, j] == 2)
                {
                    GUI.Button(new Rect(280 + i * 80, 220 + j * 80, 80, 80), "X");
                }
                else if (GUI.Button(new Rect(280 + i * 80, 220 + j * 80, 80, 80), "") && result == 0)
                {
                    if (turn == 1)
                    {
                        grid[i, j] = 1;
                    }
                    else
                    {
                        grid[i, j] = 2;
                    }
                    turn = -turn;
                }
            }
        }
    }

    int judge()
    {
        // 横向连线    
        for (int i = 0; i < 3; ++i)
        {
            if (grid[i, 0] != 0 && grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])
            {
                return grid[i, 0];
            }
        }
        //纵向连线    
        for (int j = 0; j < 3; ++j)
        {
            if (grid[0, j] != 0 && grid[0, j] == grid[1, j] && grid[1, j] == grid[2, j])
            {
                return grid[0, j];
            }
        }
        //斜向连线    
        if (grid[1, 1] != 0 &&
            grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] ||
            grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])
        {
            return grid[1, 1];
        }
        //全部格子都被点击
        bool allClick = true;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[i, j] == 0)
                {
                    allClick = false;
                }
            }
        }
        if (allClick)
            return 3;

        return 0;
    }
}

