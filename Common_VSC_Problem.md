
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
   請確認dotnet已經安裝完畢，並且重開VSC，再重新測試。</br>
   </br>
   若仍顯示錯誤請打開你們電腦的Terminal,</br>
   mac/windows 輸入： where dotnet</br>
   linux 輸入： whereis dotnet</br>
   它會出現你dotnet binary的安裝位置</br>
   例如：</br>
   <img src="https://imgur.com/bbv4zYC.jpg"
     alt="Where is dotnet?"
     style="float: left; margin-right: 10px;" /> </br>
   代表我的dotnet指令為： 令電腦執行 裝在/user/bin/資料夾下 的dotnet檔案</br>
   接著打開你VSC profile中的.vscode/tasks.json檔案 </br>
   將上圖中的"/user/bin/"路徑加入tasks.json中"三個</br>
   修改前，</br>
   <img src="https://imgur.com/ulm8tSr.jpg"
     alt="find tasks.json"
     style="float: left; margin-right: 10px;" /> </br>
   修改後，</br>
   <img src="https://imgur.com/xDrZSBe.jpg"
     alt="find tasks.json"
     style="float: left; margin-right: 10px;" /> </br>
   Ctrl + S 儲存tasks.json的變更後，應該就能build了</br>
</p>    
<h1>
   3. 我VSC裝完也能Debug了，但是我想用外部Terminal，</br>
   而且我用Console.ReadLine()函數，VSC的Terminal不會讀我的input</br>
</h1>
<p>
   據老師陳述：VSC的Terminal，不太好用</br>
   所以前助教的安裝教學中，有請用VSC的同學，把專案的執行/Debug設定在VSC外的terminal。
   方法如下：
   一樣，在你的專案profile中 打開.vscode/launch.json檔案</br>  
   把
   "console": "internalConsole" 
   改成
   "console": "externalTerminal"  
   接著儲存變更。就可以用外部Terminal Debug了
   <img src="https://imgur.com/A9jYPvj.jpg"
     alt="find launch.json"
     style="float: left; margin-right: 10px;" /> </br> 
</p>   
<h1>
4. 我123都照著做了，也有跳出一個Terminal了。</br>
   Terminal裡面還是沒有output, 但VSC也沒有顯示錯誤訊息。</br>
</h1>
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

<h1>
5. 其他
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

   
