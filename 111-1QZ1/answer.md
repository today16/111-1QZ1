# 第1次隨堂-隨堂-QZ1
>
>學號：109111121
><br />
>姓名：邱致謙
><br />
>作業撰寫時間：20 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/09/26
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

```csharp
int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
char[,] ia_Map = new char[10, 10];
```
以上程式碼是宣告array

```csharp01
for (int i_Row = 0; i_Row < 10; i_Row++)
    {
        for (int i_Col = 0; i_Col < 10; i_Col++)
        {
            ia_Map[i_Row, i_Col] = 'o';
        }
    }
```
以上程式碼是給2d array值

```csharp02
for (int i_Ct = 0; i_Ct < 10; i_Ct++)
    {
        int i_Row = ia_MIndex[i_Ct] / 10;
        int i_Col = ia_MIndex[i_Ct] % 10;
        ia_Map[i_Row, i_Col] = '*';
    }
```
以上程式碼是踩地雷的演算法

```csharp03
for (int i_Row = 0; i_Row < 10; i_Row++)
    {
        for (int i_Col = 0; i_Col < 10; i_Col++)
        {
            Response.Write(ia_Map[i_Row, i_Col]);
        }
            Response.Write("<br />");
    }
}
```
以上程式碼是印出結果



## 個人認為完成作業須具備觀念

這一題比較吃邏輯，還好老師有講解，不然對基本語法還不太熟悉的我們還是有點困難，之前比較少用到多維陣列。

