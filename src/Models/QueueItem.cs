using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuiceboxServer.Models
{
    [Table("QueueItem")]
    public class QueueItem
    {
        /// <summary>
        /// The identifier of a single song on a queue.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The party that the queue belongs to.
        /// </summary>
        [ForeignKey("Id")]
        public Party Party {  get; set; } = null!;
        
        /// <summary>
        /// The URI of the Spotify track.
        /// </summary>
        public Uri? SpotifyUri { get; set; }

        /// <summary>
        /// The title of the song.
        /// </summary>
        public string? SongTitle { get; set; }

        /// <summary>
        /// The artist of the song.
        /// </summary>
        public string? SongArtist { get; set; }

        /// <summary>
        /// The duration of the song, in milliseconds.
        /// </summary>
        public int SongDuration { get; set; }
    }
}