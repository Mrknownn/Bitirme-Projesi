"use client";
import PopularNewsDetailPage from '../page'

const PopularNewsDetail = ({ params }) => {


    if (params.id)
        return <PopularNewsDetailPage id={params.id} />;
};

export default PopularNewsDetail