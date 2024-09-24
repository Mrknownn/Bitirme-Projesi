

import ScrollToTopUI from '../scroll-to-top/scroll-to-top';
import { useBackgroundImageLoader } from '../use-background-image/use-background-image';

const Footer = () => {

  useBackgroundImageLoader()
  return (
    <>
      <ScrollToTopUI />
      {/* *** START FOOTER *** */}
      <footer
        className="main-footer bg-img"
        data-image-src="assets/images/footerBg.jpg"
      >
        <div className="container position-relative z-1">
          <div className="g-3 row">
            <div className="col-md-3">
              <img
                src="/assets/images/ico/Logo.png"
                alt="footer logo"
                className="img-fluid"
              />
            </div>
            <div className="col-md-8">
              <p className="text-white mb-0">
                Welcome to News from World, your trusted source for unbiased and timely global news coverage. Explore our comprehensive range of articles, analysis, and opinion pieces that keep you informed on the most pressing issues around the globe. Stay connected with us for insightful commentary and in-depth reporting that spans all corners of the world. For inquiries, partnerships, or suggestions, please contact us at newsfromworld@gmail.com. Follow us on social media to stay updated with the latest news.
              </p>
            </div>
          </div>
        </div>
      </footer>

      <div className="sub-footer">
        <div className="container">
          <div className="align-items-center g-1 g-sm-3 row">
            <div className="col text-center text-sm-start">
              <div className="copy">Copyright@2024 NFW Inc.</div>
            </div>
            <div className="col-sm-auto">
              <ul className="footer-nav list-unstyled text-center mb-0">
                <li className="list-inline-item">
                  <a href="/contact">Contact</a>
                </li>
                <li className="list-inline-item">
                  <a href="/about">About</a>
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>


    </>
  );
};

export default Footer;