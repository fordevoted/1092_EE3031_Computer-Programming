
<h1>
   1. 於mac上安裝visual studio code:
</h1>
<p>
   請參考老師的講義：</br>
   https://cool.ntu.edu.tw/courses/4605/files/563742?module_item_id=168414</br>
   或前助教的講義(step-by-step)：</br>
   https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/course%20material/MAC_VS_Code_Installation.pdf</br>
</p>
<h1>
   2. 我VSC裝完了，也照著講義用Termianl建立一個專案了。</br>
   VSC還是跟我講錯誤，不能build</h1>
<p>   
   如果你VSC在build專案時，於VSC的Terminal顯示以下錯誤訊息</br>
   The terminal process failed to launch: Path to shell executable "dotnet" is not a file of a symlink.</br>
   這是代表了你的VSC Terminal並不知道dotnet是什麼意思（或稱，它不知道你的dotnet裝在哪裡）</br>
   請確認dotnet已經安裝完畢，且有將dotnet加入系統環境變數中，並且重開VSC，再重新測試。</br>
</p>    
<h1>
   3. (必要)</br>
      使用Console.ReadLine()函數，VSC的Terminal無法讀input</br>
</h1>
<p>
   C# extension的debugger-launchjson.md有寫到</br>
   "internalConsole" does **NOT** work for applications that want to read from the console.</br>
   所以前助教的安裝教學中，有請用VSC的同學，把專案的執行/Debug設定為terminal。
   方法如下：</br>
   在你的專案profile中 打開.vscode/launch.json檔案</br>  
   把</br>
   "console": "internalConsole" </br>
   改成</br>
   "console": "externalTerminal"</br>
   或是</br>
   "console": "integratedTerminal"</br>
   接著儲存變更。就可以用Terminal Debug了</br>
   <img src="https://imgur.com/A9jYPvj.jpg"
     alt="find launch.json"
     style="float: left; margin-right: 10px;" /> </br> 
</p>   
<h1>
4. 我123都照著做了，也有跳出一個Terminal了。</br>
   Terminal裡面還是沒有output, 但VSC也沒有顯示錯誤訊息。</br>
</h1>
<p>
   測試的結果為，若你有自己裝其他的Terminal emulator(例如 tmux/terminator)</br>
   在你額外開一個Terminal的情況下進行Debug，它就不會有輸出。</br>
   請你去VSC的Preferences下的setting(可以由Ctrl + , 進入setting)</br>
   <img src="https://imgur.com/SgdL3YZ.jpg"
     alt="go to setting"
     style="float: left; margin-right: 10px;" /> </br>
   搜尋Terminal相關設定，找到這一欄 Terminal > External</br>
   <img src="https://imgur.com/i27G8Sx.jpg"
    alt="search terminal in setting"
    style="float: left; margin-right: 10px;" /> </br>
   根據你自己的作業系統，把它改成預設Terminal emulator，</br>
   就可以在開其他Terminal下同時Debug了。
</p>   
<h1>
5. 在Debug時, 不管用 F5 還是Ctrl + F5，Terminal都會在執行完後自動關閉。</br>
</h1>
<p>
   目前這個問題好像都發生在Windows版的VSC上。</br>
   原因未知, 但應急解法如下,</br>
   法一:</br>
   老師建議：在各位同學的程式最後加上Console.ReadLine()，就可以在Debug後，達到</br>
   請按任意鍵繼續...</br>
   的效果。</br>
   法二:</br>
   有同學是將上述第3點的</br>
   "console": "internalConsole" </br>
   改成</br>
   "console": "integratedTerminal" </br>
   這樣即使Debubg完程式自動結束, 但輸出結果仍會留在VSC的Terminal上.</br>
   也不失為一種好方法.</br>
</p>

<h1>
6. (非必要)</br>
   每次新建專案, 都要等他create .vscode這個資料夾,</br>
   而且他default又是"console":"internalConsole",</br>
   還要再修改好麻煩, 是否有一勞永逸的方法?
</h1>
<p>
   為了避免我們自行修改Extension/vscode的檔案, 最後改不回來.</br>
   建議使用VSC的使用者設定, 來做環境測試/修改.</br>
   方法如下:</br>
   打開VSC, 輸入Ctrl + , 進入setting後點右上角這個文件的圖示</br>
   <img src="https://imgur.com/2lsq4vj.jpg"
    alt="find setting.json"
    style="float: left; margin-right: 10px;" /> </br>
   或</br>
   從路徑 C:\Users\user\AppData\Roaming\Code\User\ </br>
   就可以找到並打開我們的vscode的setting.json</br>
   </br>
   把以下連結中的{}內容全部複製過去我們的setting.json的{}中,</br>
   https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/course%20material/settings.json</br>
   往後新建專案應該就不用等他建.vscode,</br>
   也不用一直改"console":"integratefTerminal"/</br>
   NOTE1:</br>
   這個檔案只包含了原本在.vscode資料夾下, launch.json及tasks.json的內容, </br>
   直接覆蓋原檔的話, 你的額外設定(ex:theme, 非內建terminal direction)會跑掉.</br>
   NOTE2:</br>
   這個檔案目前只適用於:名稱"不包含斜線(/)"的console專案, 請要使用的同學注意專案的命名.</br>
   NOTE3:</br>
   若在嘗試的過程出了問題, 直接把setting.json內容全刪, 改回{}即可.</br>
   NOTE4:</br>
   有興趣自己調整環境的同學可以參考:</br>
   VSC syntax_variable:https://code.visualstudio.com/docs/editor/variables-reference </br>
   VSC debugger:https://github.com/microsoft/vscode-docs/blob/vnext/docs/editor/debugging.md#global-launch-configuration </br>
</p>
.</br>
.</br>
.</br>
<h1>
100. 其他
</h1>
<p>
   若還有其他關於Visual Studio Code/ Visual Studio的環境設定問題，
   歡迎寄信向助教詢問，可以的話請附上你的螢幕截圖，或 錯誤訊息。
   這樣我們也比較好協助同學們解決IDE的問題。
</p>   
  
>   初學者在IDE設定上常常會覺得很痛苦，想打退堂鼓。</br>
>   不過IDE設定遇到問題，完全不代表不適合學寫程式。</br>
>   硬要扯的話，只有老師所提到的：</br>
>   希望在這堂課培養同學自學的能力</br>
>   有相關。</br>
>   祝同學學業順利。

   
