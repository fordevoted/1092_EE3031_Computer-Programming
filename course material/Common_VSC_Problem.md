# VS Code Common Problem

## 於mac上安裝visual studio code:
   請參考老師的講義
   https://cool.ntu.edu.tw/courses/4605/files/563742?module_item_id=168414
   或前助教的講義
   https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/course%20material/MAC_VS_Code_Installation.pdf


## VSC顯示錯誤，不能build專案
   如果你VSC在build專案時，於VSC的Terminal顯示以下錯誤訊息
   ```
   The terminal process failed to launch: Path to shell executable "dotnet" is not a file of a symlink.
   ```
   這是代表了你的VSC Terminal並不知道dotnet是什麼意思（或稱，它不知道你的dotnet裝在哪裡）\
   請確認dotnet已經安裝完畢，且有將dotnet加入系統環境變數中，並且重開VSC，再重新測試。


## 使用Terminal來Debug
   :rotating_light:**重要**:rotating_light: \
   C# extension的debugger-launchjson.md中寫到
   ```
   "internalConsole" does **NOT** work for applications that want to read from the console.
   ```
   故要請同學把Debugger設為於terminal中執行
   1. 在你的專案profile中 打開.vscode/launch.json檔案
   2. 把 "console": "internalConsole" 改成 "console": "integratedTerminal" , 接著Ctrl + S儲存變更。就可以用Terminal Debug了 \
   ![find_launch.json](https://imgur.com/opqGmUH.jpg)
  
  
## 在使用外部Terminal Debug時, Terminal沒有印出結果, 但VSC也沒有顯示錯誤
   測試的結果為，若你有自己裝其他的split Terminal emulator(例如 tmux/terminator) \
   在你額外開一個Terminal的情況下進行Debug，它就不會有輸出。 \
   請你去VSC的Preferences下的setting(可以由Ctrl + , 進入setting) \
   ![go_to_setting](https://imgur.com/SgdL3YZ.jpg) \
   搜尋Terminal相關設定，找到這一欄 Terminal > External \
   ![search_terminal_in_setting](https://imgur.com/i27G8Sx.jpg) \
   根據你自己的作業系統，把它改回預設的Terminal emulator \
   就可以在開其他Terminal下同時Debug了。


## 在Debug時, 不管用 F5 還是Ctrl + F5，Terminal都會在執行完後自動關閉。
   目前這個問題好像都發生在Windows版的VSC上。 \
   原因未知, 但應急解法如下
### 法一
   老師建議：在各位同學的程式最後加上Console.Read()，就可以在Debug後，達到
   請按任意鍵繼續...
   的效果。
### 法二
   有同學一開始就自行將上述第3點的 \
   "console": "internalConsole" 改成 "console": "integratedTerminal" \
   這樣即使Debubg完程式自動結束, 但輸出結果仍會留在VSC的Terminal上. \
   也不失為一種好方法.


## Debugger環境設定
   有同學反應
>  每次新建專案, 都要等他create .vscode這個資料夾, \
>  而且他default又是"console":"internalConsole", \
>  還要再修改好麻煩, 是否有一勞永逸的方法?

   為了避免我們自行修改Extension/vscode的檔案, 最後改不回來.
   建議使用VSC的使用者設定, 來做環境測試/修改.
   方法如下:
1. 打開VSC, 輸入Ctrl + , 進入setting後點右上角左邊這個文件的圖示 \
   ![open_setting.json](https://imgur.com/AY6NoZD.jpg) \
   或從路徑 C:\Users\user\AppData\Roaming\Code\User\ \
   找到並打開我們的vscode的setting.json
   
2. 把以下連結中的{}內容全部複製過去我們的setting.json的{}中, \
   https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/course%20material/settings.json \
   往後新建專案應該就不用等他建.vscode, \
   也不用一直改"console":"integratedTerminal"了
   
### NOTE:
    I  . 這個檔案只包含了原本在.vscode資料夾下, launch.json及tasks.json的內容, 
         直接覆蓋原檔的話, 你的額外設定(ex:theme, 非內建terminal direction)會跑掉.
    II . 這個檔案目前只適用於:名稱"不包含斜線(/)"的console專案, 請要使用的同學注意專案的命名.
    III. 若在嘗試的過程出了問題, 直接把setting.json內容全刪, 改回{}即可.
    IV . 有興趣自己調整環境的同學可以參考:
         VSC syntax_variable:https://code.visualstudio.com/docs/editor/variables-reference 
         VSC debugger:https://github.com/microsoft/vscode-docs/blob/vnext/docs/editor/debugging.md#global-launch-configuration 


## 其他
   若還有其他關於Visual Studio Code/ Visual Studio的環境設定問題，\
   歡迎寄信向助教詢問，來信請附上你的:x:**錯誤訊息**:x:，或**螢幕截圖**。 \
   這樣我們也比較好協助同學們解決IDE的問題。 
  
>   初學者在IDE設定上常常會覺得很痛苦，想打退堂鼓。 \
>   不過IDE設定遇到問題，完全不代表不適合學寫程式。 \
>   硬要扯的話，只有老師所提到的： \
>   希望在這堂課培養同學自學的能力 \
>   有相關。 \
>   祝同學學業順利。

  
