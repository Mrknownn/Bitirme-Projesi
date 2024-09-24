
"use client"
import React, { useState } from 'react';

const YoutubeVideo = ({initialVideos}) => {

  const [selectedVideo, setSelectedVideo] = useState(0);

  const handleThumbnailClick = (index) => {
    setSelectedVideo(index);
  };
  return (
    <div className="youtube-wrapper">
      <div className="playlist-title">
        <h4>Latest Video News</h4>
      </div>
      <div id="rypp-demo-1" className="RYPP r16-9" data-rypp="da4e5dd6">
        <div>
          <div className="RYPP-playlist">
            <header>
              <h2 className="_h1 RYPP-title">Playlist title</h2>
              <p className="RYPP-desc">
                Playlist subtitle <a href="#" target="_blank">#hashtag</a>
              </p>
            </header>
            <div className="RYPP-items">
              <ol>
                {initialVideos.map((video, index) => (
                  <li
                    key={`thumbnail-${index}`}
                    data-video-id={video.videoDataNumber}
                    className={selectedVideo === index ? 'selected' : ''}
                    onClick={() => handleThumbnailClick(index)}
                  >
                    <p className="title">
                      {video.videoPartName}
                      <small className="author">
                        <br />
                        {video.videoAuthor}
                      </small>
                    </p>
                    <img
                      src={video.videoUrl}
                      className="thumb"
                      alt={`Thumbnail ${index + 1}`}
                    />
                  </li>
                ))}
              </ol>
            </div>
          </div>
        </div>
        <div className="RYPP-video">
          {initialVideos.map((video, index) => (
            <iframe
              key={`RYPP-vp-da4e5dd6-${index}`}
              className="RYPP-video-player"
              style={{ display: index === selectedVideo ? 'block' : 'none' }}
              id={`RYPP-vp-da4e5dd6-${index}`}
              name={`RYPP-vp-da4e5dd6-${index}`}
              frameBorder="0"
              allowFullScreen
              title="YouTube Video Player"
              width="640"
              height="360"
              src={`https://www.youtube.com/embed/${video.videoDataNumber}`}
            ></iframe>
          ))}
        </div>
      </div>
    </div>
  );
};

export default YoutubeVideo;