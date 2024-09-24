
import Link from 'next/link';
import { usePathname } from 'next/navigation';
import React, { useEffect, useState } from 'react';
import { WiDayLightning } from 'weather-icons-react';
import axios from 'axios';
import { formatDate } from '../utils/dateFormatter';
const HomeLinks = [
    { href: '/about', text: 'About Us' },
    { href: '/contact', text: 'Contact' },

];
const Header = () => {
    const [weather,setWeather]=useState('')
    const [isSidebarActive, setSidebarActive] = useState(false);
    const [isOverlayActive, setOverlayActive] = useState(false);
    const [isSearchOpen, setIsSearchOpen] = useState(false);
    const path = usePathname()

    const toggleSidebar = () => {
        setSidebarActive(!isSidebarActive);
        setOverlayActive(!isOverlayActive);
    };

    const closeSidebar = () => {
        setSidebarActive(false);
        setOverlayActive(false);
    };

    useEffect(() => {
        fetchWeather();
      }, []);
    
      const fetchWeather = async () => {
        try {
          const response = await axios.get(`http://api.openweathermap.org/data/2.5/weather?lat=38.355362&lon=38.333527&appid=abe2a36e2d7701b30e0c8808105d0a81&units=metric`);
          const currentTemp = response.data.main.temp;
          setWeather(currentTemp);
        } catch (error) {
          console.error('Error fetching current weather', error);
        }
      };
      

    useEffect(() => {
        const dismissOverlay = document.querySelector('#dismiss');
        const overlay = document.querySelector('.overlay');
        const navIcon = document.querySelector('#nav-icon');

        if (dismissOverlay && overlay) {
            dismissOverlay.addEventListener('click', closeSidebar);
            overlay.addEventListener('click', closeSidebar);
        }

        if (navIcon) {
            navIcon.addEventListener('click', toggleSidebar);
        }

        // Cleanup function for removing event listeners
        return () => {
            if (dismissOverlay && overlay) {
                dismissOverlay.removeEventListener('click', closeSidebar);
                overlay.removeEventListener('click', closeSidebar);
            }
            if (navIcon) {
                navIcon.removeEventListener('click', toggleSidebar);
            }
        };
    }, [isSidebarActive, isOverlayActive]); // R
    


    return (
        <>
            <header>
                <div className="d-md-block d-none header-mid">
                    <div className="container">
                        <div className="align-items-center row justify-content-center">
                            <div className="col">
                                <div className="hstack gap-3">
                                    <div id="nav-icon" className={isSidebarActive ? 'open' : ''}>
                                        <span />
                                        <span />
                                        <span />
                                    </div>
                                    <div className="vr" />
                                    <span className="fw-semibold text-uppercase menu-text">
                                        All Section
                                    </span>
                                </div>
                            </div>
                            <div className="col-auto">
                                <div className="align-items-center d-flex gap-3">
                                    <div className="fs-5 fw-semibold weather-text">
                                        <WiDayLightning size={28} /> {weather}°C
                                    </div>
                                    <Link href="/" className="header-logo">
                                        <img
                                            src="/assets/images/ico/Logo-white.png"
                                            className="header-logo_dark"
                                            alt=""
                                        />
                                        <img
                                            src="/assets/images/ico/Logo.png"
                                            className="header-logo_white"
                                            alt=""
                                        />
                                    </Link>
                                </div>
                            </div>
                            <div className="col text-end fw-semibold text-uppercase date-text">
                                {formatDate(new Date())}
                            </div>
                        </div>
                    </div>
                </div>
                <nav className="custom-navbar navbar navbar-expand-lg sticky-top flex-column no-logo no-logo">
                    <div className="container position-relative">
                        <Link className="navbar-brand d-md-none" href="/">
                            <img
                                src="/assets/images/ico/Logo.png"
                                className="header-logo_dark"
                                alt=""
                            />
                            <img
                                src="/assets/images/ico/Logo-white.png"
                                className="header-logo_white"
                                alt=""
                            />
                        </Link>
                        {/* Start Navbar Toggler Buton */}
                        <button
                            className={`navbar-toggler ms-1`}
                            type="button"
                            data-bs-toggle="collapse"
                            data-bs-target="#navbarSupportedContent"
                            aria-controls="navbarSupportedContent"
                            aria-expanded="false"
                            aria-label="Toggle navigation"
                        >

                            <span className="navbar-toggler-icon" />
                        </button>
                        {/* End Navbar Toggler Buton */}
                        <div className={`collapse navbar-collapse`} id="navbarSupportedContent">
                            {/* Start Navbar Collapse Header */}
                            <div className="align-items-center border-bottom d-flex d-lg-none  justify-content-between mb-3 navbar-collapse__header pb-3">
                                {/* Start Brand Logo For Mobile */}
                                <div className="collapse-brand flex-shrink-0">
                                    <Link href="/">
                                        <img
                                            src="/assets/images/ico/Logo.png"
                                            className="header-logo_dark"
                                            alt=""
                                        />
                                    </Link>
                                    <Link href="/">
                                        <img
                                            src="/assets/images/ico/Logo-white.png"
                                            className="header-logo_white"
                                            alt=""
                                        />
                                    </Link>
                                </div>
                                {/* End Brand Logo For Mobile */}
                                {/* Start Collapse Close Button */}
                                <div className="flex-grow-1 ms-3 text-end">
                                    <button
                                        type="button"
                                        className="bg-transparent border-0 collapse-close p-0 position-relative"
                                        data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"
                                    >
                                        <span /> <span />
                                    </button>
                                </div>
                            </div>
                            <ul className="navbar-nav">
                                <li className="nav-item">
                                    <Link className="nav-link" href="/">
                                        Home
                                    </Link>
                                </li>

                                {HomeLinks.map((link, index) => (
                                    <li key={index} className="nav-item">
                                        <Link className={`nav-link ${path === link.href ? 'active' : ''}`} href={link.href}>
                                            {link.text} {link.badge && <span className="menu-badge">{link.badge}</span>}
                                        </Link>
                                    </li>
                                ))}

                            </ul>
                        </div>
                    </div>
                </nav>
                {/* END OF/. NAVIGATION */}
                {/* START SIDEBAR */}
                <nav id="sidebar" className={isSidebarActive ? "active p-4" : "p-4"} >
                    <div id="dismiss">
                        <i className="fas fa-arrow-left" />
                    </div>
                    <div className="d-flex flex-column h-100">
                        <div className="">
                            <Link href="/" className="d-inline-block my-3">
                                <img src="/assets/images/ico/Logo.png" alt="" height={50} />
                            </Link>
                        </div>
                        <ul className="nav d-block flex-column my-4">
                            <li className="nav-item h5">
                                <Link className="nav-link" href="/">
                                    Home
                                </Link>
                            </li>
                            <li className="nav-item h5">
                                <Link className="nav-link" href="/about">
                                    About
                                </Link>
                            </li>
                            <li className="nav-item h5">
                                <Link className="nav-link" href="/contact">
                                    Contact Us
                                </Link>
                            </li>
                        </ul>
                        <div className="mt-auto pb-3">
                            {/* Address */}
                            <p className="mb-2 fw-bold">New York, USA (HQ)</p>
                            <address className="mb-0">
                                1123 Fictional St, San Francisco, CA 94103
                            </address>
                            <p className="mb-2">
                                Call:{" "}
                                <Link href="#" className="text-white">
                                    <u>(123) 456-7890</u> (Toll-free)
                                </Link>{" "}
                            </p>
                            <Link href="#" className="d-block text-white">
                                newsfromworld@gmail.com
                            </Link>
                        </div>
                    </div>
                </nav>
                {/* END OF /. SIDEBAR */}
                <div className={isOverlayActive ? "overlay active" : "overlay"} />

            </header>
            {/* *** END OF /. PAGE HEADER SECTION *** */}

        </>
    );
};

export default Header;