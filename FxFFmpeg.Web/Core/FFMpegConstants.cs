namespace FxFFmpeg.Web.Core
{
	// ReSharper disable once InconsistentNaming
	public static class FFMpegConstants
	{
		public const string FFmpegExecutable = "ffmpeg.exe";

		public const long GByte = KByte * KByte * KByte;

		public static readonly string[] SupportedMediaExtensions =
		{
			"*.mkv",
			"*.avi",
			"*.mp4"
		};

		public const string H264 = "H264";
		// ReSharper disable once InconsistentNaming
		public const string HEVC = "HEVC";

		const long KByte = 1000;
	}
}