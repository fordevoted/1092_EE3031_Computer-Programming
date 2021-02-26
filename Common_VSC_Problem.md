
<h1>
   1. 於mac上安裝visual studio code:
</h1>
<p>
   請參考老師的講義：</br>
   https://cool.ntu.edu.tw/courses/4605/files/563742?module_item_id=168414</br>
   或前助教的講義(step-by-step)：</br>
   https://drive.google.com/file/d/1Jjr0JxH4CNsCYAuoPAzxG-KTCzPN5mD7/view?usp=sharing</br>
</p>
<h1>
   2. 阿我VSC裝完了，也照著講義用Termianl建立一個專案了。</br>
   VSC怎還是跟我講錯誤QQ，連build都不能bui內...
</h1>
<p>   
   如果你VSC在build專案時，於它內建的Terminal顯示以下錯誤訊息</br>
   The terminal process failed to launch: Path to shell executable "dotnet" is not a file of a symlink.</br>
   這是代表了你的VSC Terminal並不知道dotnet是捨摸意思（或稱，它不知道你的dotnet裝在哪裡）</br>
   請打開你們電腦的Terminal(不是VSC內建的),</br>
   mac/windows 輸入： where dotnet</br>
   linux 輸入： whereis dotnet</br>
   若你有安裝.NET且有將其加入預設的PATH(照理來說windows安裝完會自動幫你加入...?)</br>
   它會出現你dotnet binary的安裝位置</br>
   例如：</br>
   <img src="https://imgur.com/b4koOZ0.jpg"
     alt="Where is dotnet?"
     style="float: left; margin-right: 10px;" /> </br>
   代表我的dotnet指令為： 令電腦執行 裝在/home/user/dotnet/資料夾下 的dotnet檔案</br>
   接著打開你VSC profile中的.vscode/tasks.json檔案 </br>
   將上圖中的"/home/user/dotnet/"路徑加入tasks.json中"三個</br>
   "command":"dotnet"，</br>
   <img src="https://imgur.com/XAzHvRF.jpg"
     alt="find tasks.json"
     style="float: left; margin-right: 10px;" /> </br>
   Ctrl + S 儲存tasks.json的變更後，應該就能build跟debeg惹！ YA~</br>
</p>    
<h1>
   3. 阿我VSC裝完也能Debug惹，但是VSC的Terminal好醜，</br>
   而且為啥我用Console.ReadLine()函數，它就是不會讀我的input阿阿</br>
   ◢▆▅▄▃ 崩╰(〒皿〒)╯潰 ▃▄▅▆◣
</h1>
<p>
   據老師陳述：VSC的Terminal，不只PATH的預設怪怪der，好像連讀input隴美叮噹= =
   所以前助教的安裝教學中，有請用VSC的同學，把專案的執行/Debug設定在VSC外的terminal。
   方法如下：
   一樣，在你的專案profile中 打開.vscode/launch.json檔案</br>
   <img src="https://imgur.com/KzH5Feb.jpg"
     alt="find launch.json"
     style="float: left; margin-right: 10px;" /> </br>
     
   把上圖中的
   "console": "internalConsole" 
   改成
   "console": "externalTerminal"  
   接著儲存變更。就可以用外部Terminal Debug惹～～～灑花～～～～
   <img src="https://imgur.com/cRe3X6l.jpg"
     alt="succeed externalTerm"
     style="float: left; margin-right: 10px;" /> </br>
</p>   
<h1>
4. 阿我明明123都照著做了，也有跳出一個Terminal了。</br>
   為啥Terminal裡面沒有跟我Say Hello啦</br>
   (／‵Д′)／~ ╧╧ (((ﾟДﾟ;)))</br>
</h1>
   問題如下圖： </br>
   <img src="https://imgur.com/RGFomYU.jpg"
     alt="multi_term_error"
     style="float: left; margin-right: 10px;" /> </br>
   測試的結果為，若你有自己裝其他的Terminal emulator(例如 tmux/terminator)</br>
   在你額外開一個Terminal的情況下進行Debug，它就不會有輸出。</br>
   請你去VSC的Preferences下的setting(可以由Ctrl + , 進入setting)</br>
   <img src="https://imgur.com/H4kvWUn.jpg"
     alt="go to setting"
     style="float: left; margin-right: 10px;" /> </br>
   搜尋Terminal相關設定，找到這一欄 Terminal > External</br>
   <img src="https://imgur.com/haboeAG.jpg"
    alt="search terminal in setting"
    style="float: left; margin-right: 10px;" /> </br>
   根據你自己的作業系統，把它改成預設Terminal emulator，</br>
   就可以在開一堆Terminal時開心？的Debug惹～～～～</br>
   <img src="https://imgur.com/hZUc4gH"
    alt="term error fixed"
    style="float: left; margin-right: 10px;" /> </br>

<h1>
5. 其他
</h1>
<p>
   若還有其他關於Visual Studio Code/ Visual Studio的環境設定問題，
   歡迎寄信向助教詢問喔，可以的話請附上你的螢幕截圖，或 錯誤訊息。
   這樣我們也比較好協助同學們解決IDE的問題～～
</p>   
  
>   初學者在IDE設定上常常會覺得很痛苦QQ，想打退堂鼓。
>   不過IDE設定遇到問題，完全不代表不適合學寫程式。
>   硬要扯的話，只有老師所提到的：
>   希望在這堂課培養同學自學的能力
   有相關，祝同學學業順利。

   
