namespace CSharpTest
{
    internal interface IPlayer
    {
        string Play();
        string Stop();
        string Pause();
        string Pre();
        string Next();
    }

    internal class MP3 : IPlayer
    {
        public string Play()
        {
            return "正在播放 MP3 歌曲";
        }
        public string Stop()
        {
            return "停止播放 MP3 歌曲";
        }
        public string Pause()
        {
            return "停止播放 MP3 歌曲";
        }
        public string Pre()
        {
            return "播放上一首 MP3 歌曲";
        }
        public string Next()
        {
            return "播放下一首 MP3 歌曲";
        }
    }

    internal class AVI : IPlayer
    {
        public string Play()
        {
            return "正在播放 AVI 视频";
        }
        public string Stop()
        {
            return "停止播放 AVI 视频";
        }
        public string Pause()
        {
            return "停止播放 AVI 视频";
        }
        public string Pre()
        {
            return "播放上一个 AVI 视频";
        }
        public string Next()
        {
            return "播放下一个 AVI 视频";
        }
    }
}
