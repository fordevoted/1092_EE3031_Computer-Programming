# VS Code Common Problem

## 於mac上安裝visual studio code:
   請參考[老師的講義](https://cool.ntu.edu.tw/courses/4605/files/563742?module_item_id=168414) \
   或 [前助教的講義](https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/course%20material/MAC_VS_Code_Installation.pdf) \
   延伸閱讀：終端機,環境變數簡介 \
   [windows](https://cool.ntu.edu.tw/courses/4605/files/570123?module_item_id=172004) \
   [mac](https://cool.ntu.edu.tw/courses/4605/files/570124?module_item_id=172005)

## VSC顯示錯誤，不能build專案
   如果你VSC在build專案時，於VSC的Terminal顯示以下錯誤訊息
   ```
   The terminal process failed to launch: Path to shell executable "dotnet" is not a file of a symlink.
   ```
   這是代表了你的VSC Terminal並不知道dotnet是什麼意思（或稱，它不知道你的dotnet裝在哪裡）\
   請確認dotnet已經安裝完畢，且有將dotnet加入系統環境變數中，並且重開VSC，再重新測試。 \
   dotnet的安裝步驟請參考開頭的兩份講義。
   


## 使用Terminal來Debug
   :rotating_light:**重要**:rotating_light: \
   C# extension的debugger-launchjson.md中寫到
   ```
   "internalConsole" does **NOT** work for applications that want to read from the console.
   ```
   故請同學把Debugger設為於terminal中執行 \
   以下有兩種方法，供同學參考。
### 使用VSC coding，使用cmd/terminal Debug
   步驟說明請參照：[/course_material/Project_Creation.md](https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/course%20material/Project%20Creation.md#using-command-linecmd) \
   這邊只提供成功的圖例： \
   ![use_cmd](https://imgur.com/L7xQ7YS.jpg) \
   若你的Program.cs有語法錯誤： \
   ![build_error](https://imgur.com/q3Ez6LE.jpg) \
   回去VSC的coding畫面，IDE會提醒你。 \
   ![with_error](https://imgur.com/dRBEsL1.jpg) \
    \
   當然，以上全部步驟，都可以直接在VSC的integratedTerminal中執行： \
   ![use_VSC](https://imgur.com/enEpmbS.jpg)
   
### 使用VSC coding、VSC的integratedTerminal Debug
   1. 在你的專案profile中 打開.vscode/launch.json檔案 
   2. 把 "console": "internalConsole" 改成 "console": "integratedTerminal" , 接著Ctrl + S儲存變更。就可以用Terminal Debug了 \
   ![find_launch.json](https://imgur.com/opqGmUH.jpg) 
   3. Debug結果會如下圖 \
   ![use_integratedTerminal](https://imgur.com/yWBj9Nm.jpg) 
   > 第一種方法**不用等VSC建立.vscode資料夾** \
   > 但要請同學練習/學會一些基礎cmd/terminal指令。 
   > 
   > 第二種方法較為麻煩， \
   > :star2:**但可以使用VSC的Debugger功能，設定breakpoint，** \
   > :star2:**一步步的看程式運行間各變數的狀況。** 
   > 
   > 希望同學上述兩種方法都要學會， \
   > 第一種方法可以幫助我們快速瀏覽程式執行狀況， \
   > 第二種方法的Debugger，在我們遇到程式內的邏輯錯誤時，非常有用。

## 我是使用"console":"externalTerminal", 但Terminal沒有印出結果, VSC也沒有顯示錯誤
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
   老師建議：在各位同學的程式最後加上Console.ReadLine()或Console.Read()，就可以在Debug後，達到 \
   請按任意鍵繼續... \
   的效果。
### 法二
   有同學一開始就自行將上述第3點的 \
   "console": "internalConsole" 改成 "console": "integratedTerminal" \
   這樣即使Debubg完程式自動結束, 但輸出結果仍會留在VSC的Terminal上. \
   也不失為一種好方法.
### 法三
   請參照上述[使用Terminal來Debug](https://github.com/fordevoted/1092_EE3031_Computer-Programming/edit/main/course%20material/Common_VSC_Problem.md##使用Terminal來Debug)

## Debugger環境設定
   為了避免我們自行修改Extension/vscode的檔案, 最後改不回來. \
   建議使用VSC的使用者設定, 來做環境測試/修改. \
   方法如下: \
   打開VSC, 輸入Ctrl + , 進入setting後點右上角左邊這個文件的圖示 \
   ![open_setting.json](https://imgur.com/AY6NoZD.jpg) \
   或從路徑 C:\Users\user\AppData\Roaming\Code\User\ \
   找到並打開我們的vscode的setting.json \
   自行閱讀VSC的documents在setting.json中加入你的個人設定。 \
   [VSC syntax_variable](https://code.visualstudio.com/docs/editor/variables-reference) \
   [VSC debugger](https://github.com/microsoft/vscode-docs/blob/vnext/docs/editor/debugging.md#global-launch-configuration)

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

  
